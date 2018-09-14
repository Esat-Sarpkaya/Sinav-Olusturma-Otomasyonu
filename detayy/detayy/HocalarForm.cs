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
    public partial class HocalarForm : Form
    {
        public HocalarForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ENVER-EFE\SQLEXPRESS;Initial Catalog=detay;Integrated Security=True");

        private void btnHocaEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txthoca.Text))
            {
                return;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into Hocalar (HocaAdi) values(@ad)", baglanti);

            komut.Parameters.AddWithValue("@ad", txthoca.Text);
            
            int sonuc = komut.ExecuteNonQuery();
            baglanti.Close();
            if (sonuc > 0)
                MessageBox.Show("Kayıt Girildi!");
            txthoca.Text = "";
        }
    }
}
