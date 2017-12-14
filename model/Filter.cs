using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasProduction.model
{
    public class Filter : ControlDevice
    {
        public Filter()
        {
            EnabledImageDevice = (Bitmap)resourceManager.GetObject("filter_enabled");
            DisabledImageDevice = (Bitmap)resourceManager.GetObject("filter_disabled");
        }
    }
}
