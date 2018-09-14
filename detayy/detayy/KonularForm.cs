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
    public partial class KonularForm : Form
    {
        public KonularForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ENVER-EFE\SQLEXPRESS;Initial Catalog=detay;Integrated Security=True");
        private void KonularForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ders = new SqlDataAdapter("select * from Dersler", baglanti);//disconnected mimari
            DataTable ds = new DataTable();
            ders.Fill(ds);

            cmbDers.DataSource = ds;
            cmbDers.DisplayMember = "DersAdi";
            cmbDers.ValueMember = "DersID";

        }
        private void btnKonuEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into Konu (KonuAdi,DersID) values(@kad,@did)", baglanti);
            komut.Parameters.AddWithValue("@kad", txtkonu.Text);
            komut.Parameters.AddWithValue("@did", cmbDers.SelectedValue);
            int sonuc = komut.ExecuteNonQuery();
            if(sonuc>0)
                MessageBox.Show("Konu girildi!");
            txtkonu.Text = "";
        }

        
    }
}
