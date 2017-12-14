using GasProduction.model;

namespace GasProduction.sensor
{
    public class HumiditySensor : ActiveSensor
    {
        public static readonly double MAX = 0.5;
        public static readonly double NORMAL = 0.3;

        public HumiditySensor() : base(MAX, NORMAL)
        {
            
        }
    }
}
