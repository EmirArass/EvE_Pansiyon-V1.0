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
    public partial class FrmOdalar : Form
    {

        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-LCVI7NA\\SQLEXPRESS;Initial Catalog=EvePansiyon;Integrated Security=True");

        public FrmOdalar()
        {
            InitializeComponent();
        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            
            // Oda 101
            Baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * From Oda101", Baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = oku1["İsim"].ToString() + "\n" + oku1["Soyisim"].ToString();
            }
            Baglanti .Close();
            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
            }

            // Oda 102
            Baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Oda102", Baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = oku2["İsim"].ToString() + "\n" + oku2["Soyisim"].ToString();
            }
            Baglanti.Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
            }

            // Oda 103
            Baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * From Oda103", Baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda103.Text = oku3["İsim"].ToString() + "\n" + oku3["Soyisim"].ToString();
            }
            Baglanti.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
            }

            // Oda 104
            Baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * From Oda104", Baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda104.Text = oku4["İsim"].ToString() + "\n" + oku4["Soyisim"].ToString();
            }
            Baglanti.Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
            }

            //Oda 105
            Baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * From Oda105", Baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda105.Text = oku5["İsim"].ToString() + "\n" + oku5["Soyisim"].ToString();
            }
            Baglanti.Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
            }

            //Oda 106
            Baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * From Oda106", Baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda106.Text = oku6["İsim"].ToString() + "\n" + oku6["Soyisim"].ToString();
            }
            Baglanti.Close();
            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
            }

            //Oda 107
            Baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select * From Oda107", Baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda107.Text = oku7["İsim"].ToString() + "\n" + oku7["Soyisim"].ToString();
            }
            Baglanti.Close();
            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
            }

            //Oda108
            Baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select * From Oda108", Baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda108.Text = oku8["İsim"].ToString() + "\n" + oku8["Soyisim"].ToString();
            }
            Baglanti.Close();
            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
            }
            

            Baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select * From Oda109", Baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda109.Text = oku9["İsim"].ToString() + "\n" + oku9["Soyisim"].ToString();
            }
            Baglanti.Close();
            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
            }
        }
    }
}
