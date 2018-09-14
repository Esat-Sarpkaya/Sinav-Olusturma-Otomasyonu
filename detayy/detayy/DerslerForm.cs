using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace detayy
{
    public partial class DerslerForm : Form
    {
        public DerslerForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ENVER-EFE\SQLEXPRESS;Initial Catalog=detay;Integrated Security=True");
        private void DerslerForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter BolHoc = new SqlDataAdapter("select * from Bölümler Select * from Hocalar", baglanti);//disconnected mimari
            DataSet ds = new DataSet();
            BolHoc.Fill(ds);

            cmbBolum.DataSource = ds.Tables[0];
            cmbBolum.DisplayMember = "BolumAdi";
            cmbBolum.ValueMember = "BolumID";

            cmbHoca.DataSource = ds.Tables[1];
            cmbHoca.DisplayMember = "HocaAdi";
            cmbHoca.ValueMember = "HocaID";

        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtders.Text))
                return;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into Dersler (DersAdi,HocaID,BolumID) values(@ad,@hid,@bid)", baglanti);//connected mimari

            komut.Parameters.AddWithValue("@ad", txtders.Text);
            komut.Parameters.AddWithValue("@hid", cmbHoca.SelectedValue);
            komut.Parameters.AddWithValue("@bid", cmbBolum.SelectedValue);
            int sonuc = komut.ExecuteNonQuery();
            baglanti.Close();
            if (sonuc > 0)
                MessageBox.Show("Kayıt Girildi!");
            txtders.Text = "";
        }
    }
}
