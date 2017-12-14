using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GasProduction.model;

namespace GasProduction.sensor
{
    class PoisonContaminantsSensor : ActiveSensor
    {
        public static readonly double MAX = 1;
        public static readonly double NORMAL = 0.1;

        public PoisonContaminantsSensor() : base(MAX, NORMAL)
        {
        }
    }
}
