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

namespace GasProduction
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            label1.BackColor = System.Drawing.Color.Transparent;
            CenterToScreen();
        }

        private static LoadingForm loadingForm;

        static private void ShowFormStart()
        {
            loadingForm = new LoadingForm();
            Application.Run(loadingForm);
        }

        public static void ShowForm()
        {
            if (loadingForm != null)
                return;
            Thread thread = new Thread(ShowFormStart);
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();   
        }

        private delegate void CloseDelegate();

        public static void HideForm()
        {
            loadingForm.Invoke(new CloseDelegate(CloseFormInternal));
            loadingForm.Close();
        }

        static private void CloseFormInternal()
        {
            loadingForm.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}