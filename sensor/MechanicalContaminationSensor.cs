using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GasProduction.model;

namespace GasProduction.sensor
{
    class MechanicalContaminationSensor : ActiveSensor
    {
        public static readonly double MAX = 0.15;
        public static readonly double NORMAL = 0.05;

        public MechanicalContaminationSensor() : base(MAX, NORMAL)
        {
            
        }
    }
}
