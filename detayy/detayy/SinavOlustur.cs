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
    public partial class SinavOlustur : Form
    {
        public SinavOlustur()
        {
            InitializeComponent();
        }
        bool isLoded = false;

        SqlConnection baglanti = new SqlConnection(@"Data Source=ENVER-EFE\SQLEXPRESS;Initial Catalog=detay;Integrated Security=True");
        SqlDataAdapter adp;
        DataSet ds;
        DataTable dt;
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
        private void SinavOlustur_Load(object sender, EventArgs e)
        {
            FillComboBox();
            isLoded = true;

        }
        public class Soru
        {
            public int SoruID { get; set; }
            public int KonuID { get; set; }
            public int ZorlukID { get; set; }
            public string SoruText { get; set; }
            public string Secenek1 { get; set; }
            public string Secenek2 { get; set; }
            public string Secenek3 { get; set; }
            public string Secenek4 { get; set; }
            public string Secenek5 { get; set; }
            public string DogruCvp { get; set; }
        }
        List<Soru> sorular = new List<Soru>();
        SqlCommand komut;
        private void btnHazirla_Click(object sender, EventArgs e)
        {
            lstBoxA.Items.Clear();
            lstBoxB.Items.Clear();
            SoruCek();
            SoruListele();

        }

        private void SoruListele()
        {
            int sayac = 0;
            while (sayac < sorular.Count())
            {
                lstBoxA.Items.Add(sorular[sayac].SoruText);
                lstBoxA.Items.Add(sorular[sayac].Secenek1);
                lstBoxA.Items.Add(sorular[sayac].Secenek2);
                lstBoxA.Items.Add(sorular[sayac].Secenek3);
                lstBoxA.Items.Add(sorular[sayac].Secenek4);
                lstBoxA.Items.Add(sorular[sayac].Secenek5);
                lstBoxA.Items.Add("");

                lstBoxB.Items.Add(sorular[sorular.Count - (sayac + 1)].SoruText);
                lstBoxB.Items.Add(sorular[sorular.Count - (sayac + 1)].Secenek1);
                lstBoxB.Items.Add(sorular[sorular.Count - (sayac + 1)].Secenek2);
                lstBoxB.Items.Add(sorular[sorular.Count - (sayac + 1)].Secenek3);
                lstBoxB.Items.Add(sorular[sorular.Count - (sayac + 1)].Secenek4);
                lstBoxB.Items.Add(sorular[sorular.Count - (sayac + 1)].Secenek5);
                lstBoxB.Items.Add("");
                sayac++;
            }
        }
        private void SoruCek()
        {
            komut = new SqlCommand("Select * from Sorular where KonuID=" + cmbKonu.SelectedValue + " and ZorlukID= " + cmbZorluk.SelectedValue, baglanti);
            baglanti.Open();
            SqlDataReader okuyucu = komut.ExecuteReader();
            sorular.Clear();

            while (okuyucu.Read())
            {
                Soru gelen = new Soru();
                gelen.SoruID = (int)okuyucu["SoruID"];
                gelen.ZorlukID = (int)okuyucu["ZorlukID"];
                gelen.KonuID = (int)okuyucu["KonuID"];
                gelen.SoruText = okuyucu["Soru"].ToString();
                gelen.Secenek1 = okuyucu["Secenek1"].ToString();
                gelen.Secenek2 = okuyucu["Secenek2"].ToString();
                gelen.Secenek3 = okuyucu["Secenek3"].ToString();
                gelen.Secenek4 = okuyucu["Secenek4"].ToString();
                gelen.Secenek5 = okuyucu["Secenek5"].ToString();
                gelen.DogruCvp = okuyucu["DogruCvp"].ToString();

                sorular.Add(gelen);
            }
            baglanti.Close();
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
            }
        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoded)
            {
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
                adp = new SqlDataAdapter("select * from Konu where DersID=" + (int)cmbDers.SelectedValue, baglanti);
                DataTable dtKonu = new DataTable();
                adp.Fill(dtKonu);
                cmbKonu.DataSource = dtKonu;
                cmbKonu.DisplayMember = "KonuAdi";
                cmbKonu.ValueMember = "KonuID";

            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
