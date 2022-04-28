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

namespace E4Oto.Main.Pages.Modals
{
    public partial class MusteriForm : DevExpress.XtraEditors.XtraForm
    {
        public MusteriForm()
        {
            InitializeComponent();
            uoW = new UoW(new Data.Models.E4OtoServisContext());
        }
        IUoW uoW;
        public E4Oto.Data.Models.Musteriler refMusteri { get; set; }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            if (refMusteri != null)
            {
                lblId.Text = refMusteri.Id.ToString();
                txtMusteriNo.Text = refMusteri.MusteriNo;
                txtUnvani.Text = refMusteri.Unvani;
                txtTelefon1.Text = refMusteri.Telefon1;
                txtTelefon2.Text = refMusteri.Telefon2;
                txtTelefon2.Text = refMusteri.Telefon3;
                txtFax.Text = refMusteri.Fax;
                txtMail.Text = refMusteri.Mail;
                txtAdres1.Text = refMusteri.Adres1;
                txtAdres2.Text = refMusteri.Adres2;
                txtAdres3.Text = refMusteri.Adres3;
                txtIl.Text = refMusteri.Il;
                txtIlce.Text = refMusteri.Ilce;
                GRCAraclar.DataSource = refMusteri.MusteriAraclaris.ToList();
                GRCAramalar.DataSource = refMusteri.Aramalars.ToList();
                GRCRandevular.DataSource = refMusteri.Randevulars.ToList();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult = XtraMessageBox.Show("Müşteri bilgileri yeniden düzenlenecektir! Emin misiniz?", "Dikkkat",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.No) return;

            if (refMusteri == null) refMusteri = new Data.Models.Musteriler();
            else
                refMusteri = uoW.Musteriler.Find(x => x.Id == Convert.ToInt32(lblId.Text)).FirstOrDefault();

            refMusteri.MusteriNo = txtMusteriNo.Text.Trim();
            refMusteri.Unvani = txtUnvani.Text.Trim();
            refMusteri.Telefon1 = txtTelefon1.Text.Trim();
            refMusteri.Telefon2 = txtTelefon2.Text.Trim();
            refMusteri.Telefon3 = txtTelefon3.Text.Trim();
            refMusteri.Fax = txtFax.Text.Trim();
            refMusteri.Adres1 = txtAdres1.Text.Trim();
            refMusteri.Adres2 = txtAdres2.Text.Trim();
            refMusteri.Adres3 = txtAdres3.Text.Trim();
            refMusteri.Il = txtIl.Text.Trim();
            refMusteri.Ilce = txtIlce.Text.Trim();
            refMusteri.MusteriAraclaris = (List<E4Oto.Data.Models.MusteriAraclari>)GRCAraclar.DataSource;
            refMusteri.Aramalars = (List<E4Oto.Data.Models.Aramalar>)GRCAramalar.DataSource;
            refMusteri.Randevulars = (List<E4Oto.Data.Models.Randevular>)GRCRandevular.DataSource;

            if (lblId.Text == "0")
                uoW.Musteriler.Add(refMusteri);

            uoW.Complete();


        }
    }
}