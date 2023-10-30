using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvE_Pansiyon_V1._0
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniKayıt fr = new FrmYeniKayıt();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eve Pansiyon kayıt uygulaması / 2023 - Elazığ (İletişim için: ahmeremir23@gmail.com)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar Fr = new FrmOdalar();
            Fr.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToLongDateString();
            lblsaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmStoklar fr = new frmStoklar();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmGazeteler fr = new FrmGazeteler();
            fr.Show();
        }

        private void BtnSifreGuncelle_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle1 fr = new FrmSifreGuncelle1();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr = new FrmMesajlar();
            fr.Show();
        }
    }
}
