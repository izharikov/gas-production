using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GasProduction.environment;
using GasProduction.model;
using GasProduction.sensor;

namespace GasProduction
{
    public partial class GasProductionSystem : Form
    {
        public GasProductionSystem()
        {
            InitializeComponent();
            CenterToScreen();
        }

    }
}
