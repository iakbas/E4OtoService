using DevExpress.XtraSplashScreen;
using E4Oto.DAL.Bussiness;
using E4Oto.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E4Oto.Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {  
 
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<Pages.Musteriler>().Count() > 0)
            {
                Application.OpenForms.OfType<Pages.Musteriler>().ElementAt(0).Activate(); return;
            }
             
            SplashScreenManager.ShowForm(typeof(Extras.WForm));
            Pages.Musteriler E = new Pages.Musteriler()
            {
                Dock = DockStyle.Fill,
                MdiParent = this
            };
            E.BringToFront(); E.Show();
            SplashScreenManager.CloseForm(false);

           
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<Pages.Aramalar>().Count() > 0)
            {
                Application.OpenForms.OfType<Pages.Aramalar>().ElementAt(0).Activate(); return;
            }

            SplashScreenManager.ShowForm(typeof(Extras.WForm));
            Pages.Aramalar E = new Pages.Aramalar()
            {
                Dock = DockStyle.Fill,
                MdiParent = this
            };
            E.BringToFront(); E.Show();
            SplashScreenManager.CloseForm(false);

        }
    }
}
