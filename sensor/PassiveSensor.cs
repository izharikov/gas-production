using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GasProduction.model;

namespace GasProduction.sensor
{
    public abstract class PassiveSensor : Sensor
    {
        public event Action<PassiveSensor, Double, String> OnValueChanged;

        public void UpdateValue(double value, String type)
        {
            if (OnValueChanged != null)
                OnValueChanged(this, value, type);
        }
    }
}
