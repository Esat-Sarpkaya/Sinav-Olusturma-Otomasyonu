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
    public partial class SoruOlusturForm : Form
    {
        public SoruOlusturForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ENVER-EFE\SQLEXPRESS;Initial Catalog=detay;Integrated Security=True");
        private void sorularBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        bool isLoded = false;
        SqlDataAdapter adp;
        DataSet ds;
        private void SoruOlusturForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'detayDataSet.Sorular' table. You can move, or remove it, as needed.
            FillComboBox();
            isLoded = true;
        }
        void FillComboBox()
        {
            adp = new SqlDataAdapter("Select * from Fakülteler Select * from Hocalar Select * from Bölümler Select * from Dersler select * from Konu Select * from Zorluk", baglanti);
            ds = new DataSet();
            adp.Fill(ds);
            cmbFakulte.DataSource = ds.Tables[0];
            cmbFakulte.DisplayMember = "FakulteAdi";
            cmbFakulte.ValueMember = "FakulteID";

            cmbHoca.DataSource = ds.Tables[1];
            cmbHoca.DisplayMember = "HocaAdi";
            cmbHoca.ValueMember = "HocaID";

            cmbBolum.DataSource = ds.Tables[2];
            cmbBolum.DisplayMember = "BolumAdi";
            cmbBolum.ValueMember = "BolumID";

            cmbDers.DataSource = ds.Tables[3];
            cmbDers.DisplayMember = "DersAdi";
            cmbDers.ValueMember = "DersID";

            cmbKonu.DataSource = ds.Tables[4];
            cmbKonu.DisplayMember = "KonuAdi";
            cmbKonu.ValueMember = "KonuID";

            cmbZorluk.DataSource = ds.Tables[5];
            cmbZorluk.DisplayMember = "Zorluk";
            cmbZorluk.ValueMember = "ZorlukID";
        }

        private void cmbFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoded)
            {

                adp = new SqlDataAdapter("select * from Bölümler where FakulteID=@bid", baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@bid", (int)cmbFakulte.SelectedValue);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                cmbBolum.DataSource = dt;
                cmbBolum.DisplayMember = "BolumAdi";
                cmbBolum.ValueMember = "BolumID";
                //isLoded = false;
            }
        }
        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbDers.DataSource = null;
            if (isLoded)
            {
                //cmbDers.DataSource = null;
                adp = new SqlDataAdapter("select * from Dersler where BolumID=@bid", baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@bid", (int)cmbBolum.SelectedValue);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                cmbDers.DataSource = dt;
                cmbDers.DisplayMember = "DersAdi";
                cmbDers.ValueMember = "DersID";
            }
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoded)
            {
                //SqlCommand cmd = new SqlCommand("select Count(*) from Konu where DersID=" + (int)cmbDers.SelectedValue, baglanti);

                //if (baglanti.State!=ConnectionState.Open)
                //    baglanti.Open();
                //int sayi=(int)cmd.ExecuteScalar();
                //if(sayi>0)
                //{
                //cmbDers.DataSource = null;
                adp = new SqlDataAdapter("select * from Konu where DersID=" + (int)cmbDers.SelectedValue, baglanti);
                //adp.SelectCommand.Parameters.AddWithValue("@did", (int)cmbDers.SelectedValue);
                DataTable dtKonu = new DataTable();


                adp.Fill(dtKonu);
                cmbKonu.DataSource = dtKonu;
                cmbKonu.DisplayMember = "KonuAdi";
                cmbKonu.ValueMember = "KonuID";

                //cmbDers.DataSource = null;
                //cmbDers.Items.Clear();

                //}

                //if (baglanti.State == ConnectionState.Open)
                //    baglanti.Close();

            }
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=ENVER-EFE\SQLEXPRESS;Initial Catalog=detay;Integrated Security=True");

        string cevap;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into Sorular (KonuID,ZorlukID,Soru, Secenek1,Secenek2,Secenek3,Secenek4,Secenek5,DogruCvp) values(@kid,@zid,@soru,@s1,@s2,@s3,@s4,@s5,@dgr)", baglanti);
            komut.Parameters.AddWithValue("@kid", cmbKonu.SelectedValue);
            komut.Parameters.AddWithValue("@zid", cmbZorluk.SelectedValue);
            komut.Parameters.AddWithValue("@soru", txtSoru.Text);
            komut.Parameters.AddWithValue("@s1", txtSA.Text);
            komut.Parameters.AddWithValue("@s2", txtSB.Text);
            komut.Parameters.AddWithValue("@s3", txtSC.Text);
            komut.Parameters.AddWithValue("@s4", txtSD.Text);
            komut.Parameters.AddWithValue("@s5", txtSE.Text);
            if (rbA.Checked == true)
                cevap = txtSA.Text;
            else if (rbB.Checked == true)
                cevap = txtSB.Text;
            else if (rbC.Checked == true)
                cevap = txtSB.Text;
            else if (rbD.Checked == true)
                cevap = txtSB.Text;
            else if (rbE.Checked == true)
                cevap = txtSB.Text;
            else
                cevap = "olmadı";
            komut.Parameters.AddWithValue("@dgr", cevap);
            int sonuc = komut.ExecuteNonQuery();
            if (sonuc > 0)
                MessageBox.Show("Soru girildi!");
            else
                MessageBox.Show("Hata!");

            baglanti.Close();
            txtSoru.Text = txtSA.Text = txtSB.Text = txtSC.Text = txtSD.Text = txtSE.Text = "";
        }
    }
}
