using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GasProduction.environment;
using GasProduction.model;
using GasProduction.sensor;
using WMPLib;

namespace GasProduction
{
    static class Program
    {
         
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GasProductionSystem form = new GasProductionSystem();
            LoadingForm.ShowForm();
            Thread.Sleep(2000);
            Room room = new Room(form);
            LoadingForm.HideForm();
            Application.Run(form);
        }
     }
}
