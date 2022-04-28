using DevExpress.XtraEditors;
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

namespace E4Oto.Main.Pages
{
    public partial class Aramalar : DevExpress.XtraEditors.XtraForm
    {
        public Aramalar()
        {
            InitializeComponent();
            uoW = new UoW(new Data.Models.E4OtoServisContext());
        }
        IUoW uoW;
        private void Aramalar_Load(object sender, EventArgs e)
        {
            GRC.DataSource = uoW.Aramalar.GetAramalarList();
        }
    }
}