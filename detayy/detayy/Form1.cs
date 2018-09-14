using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace detayy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=ENVER-EFE/SQLEXPRESS;Initial Catalog=detay;Integrated Security=True");
        private void btnGiris_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan Çıkmak İstiyor Musunuz ?",
               "Çıkış Mesajı : ", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
                this.Close();
        }
    }
}
