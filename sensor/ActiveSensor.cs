using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GasProduction.model;

namespace GasProduction.sensor
{
    public abstract class ActiveSensor : Sensor
    {
        protected double _normal;
        protected double _max;

        public ActiveSensor(double max, double normal)
        {
            _max = max;
            _normal = normal;
        }

        public event Action<ActiveSensor> TurnOn;
        public event Action<ActiveSensor> TurnOff;

        public void UpdateValue(double value)
        {
            if (value > _max)
            {
                if (TurnOn != null)
                    TurnOn(this);
            }
            if (value <= _normal)
            {
                if (TurnOff != null)
                    TurnOff(this);
            }
        }
    }
}
