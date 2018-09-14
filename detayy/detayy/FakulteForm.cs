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
    public partial class FakulteForm : Form
    {
        public FakulteForm()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti=new SqlConnection(@"Data Source=ENVER-EFE\SQLEXPRESS;Initial Catalog=detay;Integrated Security=True");
        private void FakulteForm_Load(object sender, EventArgs e)
        {

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("Insert into Fakülteler (FakulteAdi) values(@ad)",baglanti);
            komut.Parameters.AddWithValue("@ad",txtfakulte.Text);
            int sonuc=komut.ExecuteNonQuery();
            baglanti.Close();
            if(sonuc>0)
                MessageBox.Show("Kayıt Girildi!");
            txtfakulte.Text="";
        }
    }
}
