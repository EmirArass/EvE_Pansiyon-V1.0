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
    public partial class FrmGelirGider : Form
    {
        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-LCVI7NA\\SQLEXPRESS;Initial Catalog=EvePansiyon;Integrated Security=True");
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            lblpersonelptutar.Text = (personel * 1500).ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //Kasadaki Toplam Tutar
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MusteriKayit", Baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblanaparatutar.Text = oku["toplam"].ToString();
            }
            Baglanti.Close();


            //Yiyecek Giderleri

            Baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Yiyecekler) as toplam1 from Stoklar", Baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblyiyecek.Text = oku2["toplam1"].ToString();
            }
            Baglanti.Close();

            //İçecek Giderleri

            Baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(İcecekler) as toplam2 from Stoklar", Baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblicecek.Text = oku3["toplam2"].ToString();
            }
            Baglanti.Close();

            //Yiyecek Giderleri

            Baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select sum(Atistirmalik) as toplam3 from Stoklar", Baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblatistirmalik.Text = oku4["toplam3"].ToString();
            }
            Baglanti.Close();

        }
    }
}

