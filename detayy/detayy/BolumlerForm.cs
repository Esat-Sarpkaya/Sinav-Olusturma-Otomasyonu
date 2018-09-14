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
    public partial class BolumlerForm : Form
    {
        public BolumlerForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ENVER-EFE\SQLEXPRESS;Initial Catalog=detay;Integrated Security=True");
        private void bölümlerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bölümlerBindingSource.EndEdit();
            

        }

        private void BolumlerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'detayDataSet.Bölümler' table. You can move, or remove it, as needed.
            SqlDataAdapter adp = new SqlDataAdapter("select * from Fakülteler", baglanti);
            DataTable fakulteler = new DataTable();
            adp.Fill(fakulteler);
            cmbFakulte.DataSource = fakulteler;

            cmbFakulte.DisplayMember = "FakulteAdi";
            cmbFakulte.ValueMember = "FakulteID";

        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbolum.Text))
            {
                return;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into Bölümler (BolumAdi,FakulteID) values(@ad,@fid)", baglanti);
           
            komut.Parameters.AddWithValue("@ad", txtbolum.Text);
            komut.Parameters.AddWithValue("@fid", cmbFakulte.SelectedValue);
            int sonuc = komut.ExecuteNonQuery();
            baglanti.Close();
            if (sonuc > 0)
                MessageBox.Show("Kayıt Girildi!");
            txtbolum.Text = "";
        }
    }
}
