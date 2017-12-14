using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasProduction.model
{
    public class Pump : ControlDevice
    {
        public Pump()
        {
            EnabledImageDevice = (Bitmap)resourceManager.GetObject("pump_enabled");
            DisabledImageDevice = (Bitmap)resourceManager.GetObject("pump_disabled");
        }
    }
}
