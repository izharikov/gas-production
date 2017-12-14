using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GasProduction.sensor;

namespace GasProduction.model
{
    public class ControlDevice : Device
    {
        public bool isOn { get; set; }
        public Action<ControlDevice> OnTurnedOn;
        public Action<ControlDevice> OnTurnedOff;

        public Bitmap DisabledImageDevice;
        public Bitmap EnabledImageDevice;

        public void TurnOnDevice(ActiveSensor sensor)
        {
            if (!isOn)
            {
                isOn = true;
                OnTurnedOn(this);
            }
        }

        public void TurnOffDevice(ActiveSensor sensor)
        {
            if (isOn)
            {
                isOn = false;
                OnTurnedOff(this);
            }
        }
    }
}
