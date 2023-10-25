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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LCVI7NA\SQLEXPRESS;Initial Catalog=EvePansiyon;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriKayit", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["İsim"].ToString());
                ekle.SubItems.Add(oku["Soyisim"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNO"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            MskTxtisim.Text = listView1.SelectedItems[0].SubItems[1].Text;
            MskTxtSoyisim.Text = listView1.SelectedItems[0].SubItems[2].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtMail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtTcNo.Text = listView1.SelectedItems[0].SubItems[5].Text;
            MskTxtOdaNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            MskTxtUcret.Text = listView1.SelectedItems[0].SubItems[7].Text;
            DtpGirisTarih.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpCikisTarih.Text = listView1.SelectedItems[0].SubItems[9].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            if (MskTxtOdaNo.Text == "101  ")
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("delete from Oda101", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (MskTxtOdaNo.Text == "102  ")
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("delete from Oda102", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (MskTxtOdaNo.Text == "103  ")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("delete from Oda103", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (MskTxtOdaNo.Text == "104  ")
            {
                baglanti.Open();
                SqlCommand komut4 = new SqlCommand("delete from Oda104", baglanti);
                komut4.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (MskTxtOdaNo.Text == "105  ")
            {
                baglanti.Open();
                SqlCommand komut5 = new SqlCommand("delete from Oda105", baglanti);
                komut5.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (MskTxtOdaNo.Text == "106  ")
            {
                baglanti.Open();
                SqlCommand komut6 = new SqlCommand("delete from Oda106", baglanti);
                komut6.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (MskTxtOdaNo.Text == "107  ")
            {
                baglanti.Open();
                SqlCommand komut7 = new SqlCommand("delete from Oda107", baglanti);
                komut7.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (MskTxtOdaNo.Text == "108  ")
            {
                baglanti.Open();
                SqlCommand komut8 = new SqlCommand("delete from Oda108", baglanti);
                komut8.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (MskTxtOdaNo.Text == "109  ")
            {
                baglanti.Open();
                SqlCommand komut9 = new SqlCommand("delete from Oda109", baglanti);
                komut9.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }


        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            MskTxtisim.Clear();
            MskTxtSoyisim.Clear();
            MskTxtTelefon.Clear();
            MskTxtMail.Text = "";
            txtTcNo.Clear();
            MskTxtOdaNo.Clear();
            MskTxtUcret.Clear();
            DtpGirisTarih.Text = "";
            DtpCikisTarih.Text = "";
            comboBox1.Text = "";
            

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriKayit set İsim= '" + MskTxtisim.Text + "',Soyisim='"+ MskTxtSoyisim.Text + "',Telefon='" + MskTxtTelefon.Text + "',Mail='" + MskTxtMail.Text + "',TC='" + txtTcNo.Text + "',OdaNO='" + MskTxtOdaNo.Text + "',Ucret='" + MskTxtUcret.Text + "',GirisTarihi='" + DtpGirisTarih.Value.ToString("yyyy-MM-dd")+ "',CikisTarihi='" + DtpCikisTarih.Value.ToString("yyyy-MM-dd") +"',Cinsiyet='" + comboBox1.Text + "'where ID=" + id + "",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriKayit where OdaNO like '%" + msktxtmusteriara.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["İsim"].ToString());
                ekle.SubItems.Add(oku["Soyisim"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNO"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
// Data Source=DESKTOP-LCVI7NA\\SQLEXPRESS;Initial Catalog=EvePansiyon;Integrated Security=True

// SqlCommand komut = new SqlCommand("delete from MusteriKayit where ID =(" + id + ")", baglanti);
