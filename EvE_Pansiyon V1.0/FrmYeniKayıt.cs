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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;


namespace EvE_Pansiyon_V1._0
{
    public partial class FrmYeniKayıt : Form
    {
        public FrmYeniKayıt()
        {
            InitializeComponent();
        }

        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-LCVI7NA\\SQLEXPRESS;Initial Catalog=EvePansiyon;Integrated Security=True");

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            MskTxtOdaNo.Text = "101";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101 (İsim, Soyisim) values ('" + MskTxtisim.Text + "','" + MskTxtSoyisim.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            MskTxtOdaNo.Text = "102";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (İsim, Soyisim) values('" + MskTxtisim.Text + "','" + MskTxtSoyisim.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            MskTxtOdaNo.Text = "103";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (İsim, Soyisim) values('" + MskTxtisim.Text + "','" + MskTxtSoyisim.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            MskTxtOdaNo.Text = "104";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104 (İsim, Soyisim) values('" + MskTxtisim.Text + "','" + MskTxtSoyisim.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            MskTxtOdaNo.Text = "105";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (İsim, Soyisim) values('" + MskTxtisim.Text + "','" + MskTxtSoyisim.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            MskTxtOdaNo.Text = "106";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106 (İsim, Soyisim) values('" + MskTxtisim.Text + "','" + MskTxtSoyisim.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            MskTxtOdaNo.Text = "107";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107 (İsim, Soyisim) values('" + MskTxtisim.Text + "','" + MskTxtSoyisim.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            MskTxtOdaNo.Text = "108";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108 (İsim, Soyisim) values('" + MskTxtisim.Text + "','" + MskTxtSoyisim.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            MskTxtOdaNo.Text = "109";
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109 (İsim, Soyisim) values('" + MskTxtisim.Text + "','" + MskTxtSoyisim.Text + "')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir");
        }

        private void FrmYeniKayıt_Load(object sender, EventArgs e)
        {
            // Oda 101
            Baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * From Oda101", Baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = "Dolu";
            }
            Baglanti.Close();
            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false;
            }

            // Oda 102
            Baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Oda102", Baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = "Dolu";
            }
            Baglanti.Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }

            // Oda 103
            Baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * From Oda103", Baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda103.Text = "Dolu";
            }
            Baglanti.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }

            // Oda 104
            Baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * From Oda104", Baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda104.Text = "Dolu";
            }
            Baglanti.Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }

            //Oda 105
            Baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * From Oda105", Baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda105.Text = "Dolu";
            }
            Baglanti.Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }

            //Oda 106
            Baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * From Oda106", Baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda106.Text = "Dolu";
            }
            Baglanti.Close();
            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.Enabled = false;
            }

            //Oda 107
            Baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select * From Oda107", Baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda107.Text = "Dolu";
            }
            Baglanti.Close();
            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
                BtnOda107.Enabled = false;
            }

            //Oda108
            Baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select * From Oda108", Baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda108.Text = "Dolu";
            }
            Baglanti.Close();
            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
                BtnOda108.Enabled = false;
            }

            //Oda 109
            Baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select * From Oda109", Baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda109.Text = "Dolu";
            }
            Baglanti.Close();
            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda109.Enabled = false;
            }
        }

        private void DtpCikisTarih_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarih.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarih.Text);

            TimeSpan sonuC = BuyukTarih - KucukTarih;

            label11.Text = sonuC.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 300;
            MskTxtUcret.Text = ucret.ToString();
        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriKayit(İsim, Soyisim, Telefon, Cinsiyet, Mail, TC, OdaNO, Ucret, GirisTarihi, CikisTarihi)values('"+ MskTxtisim.Text + "','" + MskTxtSoyisim.Text + "','" + MskTxtTelefon.Text + "','" + comboBox1.Text + "','" + MskTxtMail.Text + "','"+ txtTcNo.Text +"','"+ MskTxtOdaNo.Text +"','"+ MskTxtUcret.Text +"','" + DtpGirisTarih.Value.ToString("yyyy-MM-dd")+"','" + DtpCikisTarih.Value.ToString("yyyy-MM-dd")+ "')", Baglanti);

            komut.ExecuteNonQuery();
            Baglanti.Close();

            MessageBox.Show("Müşteri Kaydı Başarıyla Yapıldı");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=DESKTOP-LCVI7NA\SQLEXPRESS;Initial Catalog=EvePansiyon;Integrated Security=True