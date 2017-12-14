using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasProduction.model
{
    public class QualityDevice : ControlDevice
    {
        public QualityDevice()
        {
            EnabledImageDevice = (Bitmap)resourceManager.GetObject("magnifier_enabled");
            DisabledImageDevice = (Bitmap)resourceManager.GetObject("magnifier_disabled");
        }
    }
}
