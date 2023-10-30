using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace EvE_Pansiyon_V1._0
{
    public partial class FrmSifreGuncelle1 : Form
    {
        public FrmSifreGuncelle1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LCVI7NA\SQLEXPRESS;Initial Catalog=EvePansiyon;Integrated Security=True");
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici= '" + TxtKullaniciAdi.Text + "',Sifre='" +TxtSifre.Text +"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı...");
        }
    }
}
