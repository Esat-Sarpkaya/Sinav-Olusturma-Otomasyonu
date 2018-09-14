using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace detayy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHocalar_Click(object sender, EventArgs e)
        {
            HocalarForm f3 = new HocalarForm();
            f3.ShowDialog();
        }

        private void btnDersler_Click(object sender, EventArgs e)
        {
            DerslerForm f4 = new DerslerForm();
            f4.ShowDialog();
        }

        private void btnBolumler_Click(object sender, EventArgs e)
        {
            BolumlerForm f5 = new BolumlerForm();
            f5.ShowDialog();
        }

        private void btnFakulteler_Click(object sender, EventArgs e)
        {
            FakulteForm f6 = new FakulteForm();
            f6.ShowDialog();
        }

        private void btnKonular_Click(object sender, EventArgs e)
        {
            KonularForm f7 = new KonularForm();
            f7.ShowDialog();
        }

        private void btnSinavOlustur_Click(object sender, EventArgs e)
        {
            SinavOlustur f8 = new SinavOlustur();
            f8.ShowDialog();
        }

        private void btnSoruOlustur_Click(object sender, EventArgs e)
        {
            SoruOlusturForm f9 = new SoruOlusturForm();
            f9.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Raporla f10 = new Raporla();
            f10.ShowDialog();
        }
    }
}
