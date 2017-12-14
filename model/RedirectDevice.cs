using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasProduction.model
{
    public class RedirectDevice : ControlDevice
    {
        public RedirectDevice()
        {
            EnabledImageDevice = (Bitmap)resourceManager.GetObject("redirect_enabled");
            DisabledImageDevice = (Bitmap)resourceManager.GetObject("redirect_disabled");
        }
    }
}
