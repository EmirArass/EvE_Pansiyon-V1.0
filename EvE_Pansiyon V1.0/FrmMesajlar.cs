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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LCVI7NA\SQLEXPRESS;Initial Catalog=EvePansiyon;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriMesaj", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MesajID"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["MusteriMesaj"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriMesaj (AdSoyad, MusteriMesaj) values ('" + textBox1.Text + "','" + richTextBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.Items[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
