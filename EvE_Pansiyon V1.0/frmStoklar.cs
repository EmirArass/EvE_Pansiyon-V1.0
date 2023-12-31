﻿using System;
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
using System.Security;

namespace EvE_Pansiyon_V1._0
{
    public partial class frmStoklar : Form
    {
        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-LCVI7NA\\SQLEXPRESS;Initial Catalog=EvePansiyon;Integrated Security=True");

        private void veriler()
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Stoklar", Baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku ["Yiyecekler"].ToString();
                ekle.SubItems.Add(oku["İcecekler"].ToString());
                ekle.SubItems.Add(oku["Atistirmalik"].ToString());
                listView1.Items.Add(ekle);
            }
            Baglanti.Close();
        }

        private void veriler2()
        {
            listView2.Items.Clear();
            Baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Faturalar", Baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            Baglanti.Close();
        }

        public frmStoklar()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar (Yiyecekler, İcecekler, atistirmalik) values ('" + txtYiyecek.Text + "','" + txtİcecek.Text + "','" + txtAtistirmalik.Text+"')", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            veriler();
        }

        private void frmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            Baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Faturalar (Elektrik, Su, İnternet) values ('" + txtElektrik.Text + "','" + txtSu.Text + "','" + txtDogalgaz.Text + "')", Baglanti);
            komut2.ExecuteNonQuery();
            Baglanti.Close();
            veriler2    ();
        }
    }
}
