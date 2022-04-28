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
    public partial class Musteriler : DevExpress.XtraEditors.XtraForm
    {
        public Musteriler()
        {
            InitializeComponent();
            uoW = new UoW(new Data.Models.E4OtoServisContext());
        }
        IUoW uoW;
        private void Musteriler_Load(object sender, EventArgs e)
        {
            GRC.DataSource = uoW.Musteriler.GetAll();
        }

        private void yeniEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modals.MusteriForm _m = new Modals.MusteriForm();
            _m.ShowDialog();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GRW.DataRowCount == 0) return;
            E4Oto.Data.Models.Musteriler _musteri = (E4Oto.Data.Models.Musteriler)GRW.GetRow(GRW.FocusedRowHandle);
            Modals.MusteriForm _m = new Modals.MusteriForm();
            _m.refMusteri = _musteri;
            _m.ShowDialog();
        }
    }
}