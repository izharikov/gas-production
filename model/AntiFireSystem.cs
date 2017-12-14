using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasProduction.model
{
    public class AntiFireSystem : ControlDevice
    {
        public AntiFireSystem()
        {
            EnabledImageDevice = (Bitmap)resourceManager.GetObject("antifire_enabled");
            DisabledImageDevice = (Bitmap)resourceManager.GetObject("antifire_disabled");
        }
    }
}
