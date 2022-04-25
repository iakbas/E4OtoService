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
            uoW = new UoW(new Data.Models.E4OtoServisContext());
        }
        IUoW uoW;
        private void Form1_Load(object sender, EventArgs e)
        {  

            var musteriler = uoW.Musteriler.GetAll();

            dataGridView1.DataSource = musteriler;
        }
    }
}
