using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GasProduction.model;
using GasProduction.sensor;
using WMPLib;

namespace GasProduction.environment
{
    public class Room
    {
        private Random _rnd;

        private GasProductionSystem _mainGui;
        private Thread _backgroundThread;
        private bool _isStarted;

        // Control Devices
        private QualityDevice _qualityDevice;
        private Pump _fan1;
        private Pump _fan2;
        private RedirectDevice _redirectDevice;
        private AirFlowController _airFlowController;
        private Filter _filter;
        private AntiFireSystem _antifireSystem;
        // Devices
        private OperatorScreen _operatorScreen;

        // Active Sensors
        private HumiditySensor _humiditySensor;
        private MechanicalContaminationSensor _mechanicalContaminationSensor;
        private OverheatSensor _overheatSensor;
        private PoisonContaminantsSensor _poisonContaminantsSensor;
        private SmokeSensor _smokeSensor;

        // Passive Sensors
        private AirSpeedSensor _airSpeedSensor;
        private AirTemperatureSensor _airTemperatureSensor;

        // Parameters
        public double AirSpeed;
        public double AirTemperature;
        public double PoisonContaminants;
        public double Humidity;
        public double MechanicalContaminants;
        public double Temperature;
        public double Smoke;

        private object fireSync = new object();
        //private Bitmap sidodji = (Bitmap)new ResourceManager("VentilationSystem.Resource1",
        //        Assembly.GetExecutingAssembly()).GetObject("Sidodji");

        public Room(GasProductionSystem mainGui)
        {
            _mainGui = mainGui;
            _rnd = new Random();
            _isStarted = false;
            _backgroundThread = new Thread(RunSystem);
            _backgroundThread.IsBackground = true;
            initializeDevices();
            initializeSensors();
            initializeParameters();
            subscribeDevices();
            subcribeRoom();
            setButtonEvents();
            _mainGui.Shown += delegate
            {
                _mainGui.Invoke((MethodInvoker)Start);
            };

            _mainGui.FormClosing += delegate
            {
                _backgroundThread.Abort();
            };
        }

        private void initializeDevices()
        {
            _qualityDevice = new QualityDevice();
            _fan1 = new Pump();
            _fan2 = new Pump();
            _redirectDevice = new RedirectDevice();
            _airFlowController = new AirFlowController();
            _filter = new Filter();
            _antifireSystem = new AntiFireSystem();
            _operatorScreen = new OperatorScreen();
        }

        private void initializeSensors()
        {
            _humiditySensor = new HumiditySensor();
            _mechanicalContaminationSensor = new MechanicalContaminationSensor();
            _overheatSensor = new OverheatSensor();
            _poisonContaminantsSensor = new PoisonContaminantsSensor();
            _smokeSensor = new SmokeSensor();
            _airSpeedSensor = new AirSpeedSensor();
            _airTemperatureSensor = new AirTemperatureSensor();
        }

        private void initializeParameters()
        {
            AirSpeed = 0.05;
            AirTemperature = 23;
            PoisonContaminants = 0.01;
            Humidity = 0.3;
            MechanicalContaminants = 0.05;
            Temperature = 23;
            Smoke = 0.01;
        }

        private void RunSystem()
        {
            while (true)
            {
                // Modeling passive params
                AirTemperature += rndBool() ? _rnd.NextDouble() / 30 : -_rnd.NextDouble() / 30;
                AirSpeed += rndBool() ? _rnd.NextDouble() / 1000 : -_rnd.NextDouble() / 1000;

                // Modeling active parameters
                PoisonContaminants += _fan2.isOn ? -_rnd.NextDouble() / 100 : _rnd.NextDouble() / 100;
                Humidity += _qualityDevice.isOn ? -_rnd.NextDouble() / 300 : _rnd.NextDouble() / 300;
                MechanicalContaminants += _filter.isOn ? -_rnd.NextDouble() / 500 : _rnd.NextDouble() / 500;
                lock (fireSync)
                {
                    Temperature += _antifireSystem.isOn ? -_rnd.NextDouble() * 10 : 0;
                    Smoke += _airFlowController.isOn ? -_rnd.NextDouble() / 50 : 0;
                }
                if (_mainGui.InvokeRequired)
                {
                    _mainGui.Invoke((MethodInvoker)updateSensorValues);
                    _mainGui.Invoke((MethodInvoker)updateProgressBars);
                }
                Thread.Sleep(100);
            }
        }

        private void subscribeDevices()
        {
            _humiditySensor.TurnOn += _qualityDevice.TurnOnDevice;
            _humiditySensor.TurnOff += _qualityDevice.TurnOffDevice;
            _mechanicalContaminationSensor.TurnOn += _filter.TurnOnDevice;
            _mechanicalContaminationSensor.TurnOff += _filter.TurnOffDevice;
            _overheatSensor.TurnOn += _redirectDevice.TurnOnDevice;
            _overheatSensor.TurnOff += _redirectDevice.TurnOffDevice;
            _overheatSensor.TurnOn += _antifireSystem.TurnOnDevice;
            _overheatSensor.TurnOff += _antifireSystem.TurnOffDevice;
            _poisonContaminantsSensor.TurnOn += _fan2.TurnOnDevice;
            _poisonContaminantsSensor.TurnOff += _fan2.TurnOffDevice;
            _smokeSensor.TurnOn += _airFlowController.TurnOnDevice;
            _smokeSensor.TurnOff += _airFlowController.TurnOffDevice;
            _airSpeedSensor.OnValueChanged += _operatorScreen.ValueChanged;
            _airTemperatureSensor.OnValueChanged += _operatorScreen.ValueChanged;
        }

        private void subcribeRoom()
        {
            _qualityDevice.OnTurnedOn += TurnOnDevice;
            _qualityDevice.OnTurnedOff += TurnOffDevice;
            _filter.OnTurnedOn += TurnOnDevice;
            _filter.OnTurnedOff += TurnOffDevice;
            _antifireSystem.OnTurnedOn += TurnOnDevice;
            _antifireSystem.OnTurnedOff += TurnOffDevice;
            _fan2.OnTurnedOn += TurnOnDevice;
            _fan2.OnTurnedOff += TurnOffDevice;
            _airFlowController.OnTurnedOn += TurnOnDevice;
            _airFlowController.OnTurnedOff += TurnOffDevice;
            _operatorScreen.OnValueChanged += ShowValue;
            _redirectDevice.OnTurnedOn += TurnOnDevice;
            _redirectDevice.OnTurnedOff += TurnOffDevice;
        }

        private void TurnOnDevice(ControlDevice device)
        {
            Type deviceType = device.GetType();
            switch (deviceType.Name)
            {
                case "AirFlowController":
                    _mainGui.AirFlowControllerPB.Image = device.EnabledImageDevice;
                    break;
                case "AntiFireSystem":
                    _mainGui.AntiFirePB.Image = device.EnabledImageDevice;
                    break;
                case "QualityDevice":
                    _mainGui.ConditionerPB.Image = device.EnabledImageDevice;
                    break;
                case "Pump":
                    _mainGui.FanPB2.Image = device.EnabledImageDevice;
                    break;
                case "Filter":
                    _mainGui.FilterPB.Image = device.EnabledImageDevice;
                    break;
                case "RedirectDevice":
                    _mainGui.RedirectPB.Image = device.EnabledImageDevice;
                    break;
            }
        }


        private void TurnOffDevice(ControlDevice device)
        {
            Type deviceType = device.GetType();
            switch (deviceType.Name)
            {
                case "AirFlowController":
                    _mainGui.AirFlowControllerPB.Image = device.DisabledImageDevice;
                    break;
                case "AntiFireSystem":
                    _mainGui.AntiFirePB.Image = device.DisabledImageDevice;
                    break;
                case "QualityDevice":
                    _mainGui.ConditionerPB.Image = device.DisabledImageDevice;
                    break;
                case "Pump":
                    _mainGui.FanPB2.Image = device.DisabledImageDevice;
                    break;
                case "Filter":
                    _mainGui.FilterPB.Image = device.DisabledImageDevice;
                    break;
                case "RedirectDevice":
                    _mainGui.RedirectPB.Image = device.DisabledImageDevice;
                    break;
            }
        }

        private void setButtonEvents()
        {
            this._mainGui.StartButton.Click += new System.EventHandler(StartSystem);
            this._mainGui.FireButton.Click += new System.EventHandler(StartFire);
            this._mainGui.ApplyModelingButton.Click += new System.EventHandler(ApplyParameters);
        }

        private void ShowValue(PassiveDevice device, double value, String type)
        {
            Type deviceType = device.GetType();
            String format = String.Format("{0}{1}", "F", 4);
            switch (deviceType.Name)
            {
                case "OperatorScreen":
                    switch (type)
                    {
                        case "SPEED":
                            _mainGui.AirSpeedLabel.Text = value.ToString(format);
                            break;
                        case "TEMP":
                            _mainGui.AirTemperatureLabel.Text = value.ToString(format);
                            break;
                    }
                    break;
            }
        }

        private void updateProgressBars()
        {
            _mainGui.SmokeProgressBar.Value = (int)(Smoke * 100);
            _mainGui.TempProgressBar.Value = (int)Temperature;
            _mainGui.HumidityProgressBar.Value = (int)(Humidity * 100);
            _mainGui.MechContProgressBar.Value = (int)(MechanicalContaminants * 1000);
            _mainGui.PoisonContProgressBar.Value = (int)(PoisonContaminants * 100);
        }

        private void updateSensorValues()
        {
            _humiditySensor.UpdateValue(Humidity);
            _mechanicalContaminationSensor.UpdateValue(MechanicalContaminants);
            _overheatSensor.UpdateValue(Temperature);
            _poisonContaminantsSensor.UpdateValue(PoisonContaminants);
            _smokeSensor.UpdateValue(Smoke);
            _airSpeedSensor.UpdateValue(AirSpeed, "SPEED");
            _airTemperatureSensor.UpdateValue(AirTemperature, "TEMP");
        }

        private void ApplyParameters(object o, EventArgs e)
        {
            Humidity = (double)_mainGui.HumidityUpDown.Value / 100.0;
            MechanicalContaminants = (double)_mainGui.MechanicalContaminantsUpDown.Value / 1000.0;
            PoisonContaminants = (double)_mainGui.PoisonContaminantsUpDown.Value / 100.0;
        }

        private bool rndBool()
        {
            return _rnd.Next(0, 2) == 0;
        }

        private void StartFire(object o, EventArgs e)
        {
            lock (fireSync)
            {
                Temperature = 750;
                Smoke = 1.1;
            }
        }

        public void StartSystem(object o, EventArgs e)
        {
            if (!_isStarted)
            {
                _mainGui.StartButton.Text = "ПРИОСТАНОВИТЬ";
                _isStarted = true;
                _backgroundThread = new Thread(RunSystem);
                _backgroundThread.IsBackground = true;
                _backgroundThread.Start();
            }
            else
            {
                _mainGui.StartButton.Text = "ПРОДОЛЖИТЬ";
                _isStarted = false;
                _backgroundThread.Abort();
            }
        }

        async void Start()
        {
            _mainGui.Enabled = false;
            _mainGui.StartButton.Text = "ПРИОСТАНОВИТЬ";
            _isStarted = true;
            _backgroundThread = new Thread(RunSystem);
            _backgroundThread.IsBackground = true;
            _backgroundThread.Start();
            _mainGui.Enabled = true;
        }
    }
}

