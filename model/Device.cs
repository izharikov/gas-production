using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace GasProduction.model
{
    public abstract class Device
    {
        protected ResourceManager resourceManager;

        public Device()
        {
            resourceManager = new ResourceManager("GasProduction.Resource1", 
                Assembly.GetExecutingAssembly());
        }
    }
}
