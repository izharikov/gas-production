using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GasProduction.sensor;

namespace GasProduction.model
{
    public class PassiveDevice : Device
    {
        public Action<PassiveDevice, Double, String> OnValueChanged;

        public double AirTemperature { get; set; }
        public double AirSpeed { get; set; }

        public void ValueChanged(PassiveSensor sensor, double value, String type)
        {
            OnValueChanged(this, value, type);
        }
    }
}
