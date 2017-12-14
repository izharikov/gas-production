using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GasProduction.model;

namespace GasProduction.sensor
{
    class OverheatSensor : ActiveSensor
    {
        public static readonly double MAX = 600;
        public static readonly double NORMAL = 70;

        public OverheatSensor() : base(MAX, NORMAL)
        {
        }
    }
}
