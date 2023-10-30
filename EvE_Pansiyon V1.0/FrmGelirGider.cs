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
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Lütfen personel sayısını giriniz");
            }
            else
            {
                int personel;
                personel = Convert.ToInt32(textBox1.Text);
                lblpersonelptutar.Text = (personel * 1500).ToString();
            }
           
            int giris;
            giris = Convert.ToInt32(lblanaparatutar.Text);
            int cikti;
            cikti= Convert.ToInt32(lblpersonelptutar.Text) +  Convert.ToInt32(lblyiyecek.Text) + Convert.ToInt32(lblicecek.Text) + Convert.ToInt32(lblatistirmalik.Text) + Convert.ToInt32(lblelektrik.Text) + Convert.ToInt32(lblsu.Text) + Convert.ToInt32(lbldogalgaz.Text);
            int sonuc = giris - cikti;
            lblgelir.Text= sonuc.ToString();


            //lblgelir.Text = sonuc.ToString(); (+ ve - durumunu hep pozitif sayı olarak yazdığı için iki değişkene atayıp toplamlarını farklı bir değişkende yazdırdım)
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

            //Atıştırmalık Giderleri

            Baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select sum(Atistirmalik) as toplam3 from Stoklar", Baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblatistirmalik.Text = oku4["toplam3"].ToString();
            }
            Baglanti.Close();

            //Elektrik Giderleri

            Baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(Elektrik) as toplam4 from Faturalar", Baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblelektrik.Text = oku5["toplam4"].ToString();
            }
            Baglanti.Close();


            //Su Giderleri

            Baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select sum(Su) as toplam5 from Faturalar", Baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblsu.Text = oku6["toplam5"].ToString();
            }
            Baglanti.Close();



            //İnternet Giderleri

            Baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select sum(İnternet) as toplam6 from Faturalar", Baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lbldogalgaz.Text = oku7["toplam6"].ToString();
            }
            Baglanti.Close();

        }
    }
}

