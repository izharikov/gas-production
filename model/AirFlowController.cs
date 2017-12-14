using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace GasProduction.model
{
    public class AirFlowController : ControlDevice
    {
        public AirFlowController()
        {
            EnabledImageDevice = (Bitmap)resourceManager.GetObject("arrow_outside");
            DisabledImageDevice = (Bitmap)resourceManager.GetObject("arrow_inside");
        }
    }
}
