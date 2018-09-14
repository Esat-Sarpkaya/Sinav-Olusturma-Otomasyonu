namespace detayy
{
    partial class KonularForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtkonu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKonuEkle = new System.Windows.Forms.Button();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtkonu
            // 
            this.txtkonu.Location = new System.Drawing.Point(135, 84);
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Size = new System.Drawing.Size(100, 22);
            this.txtkonu.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Konu Adı:";
            // 
            // btnKonuEkle
            // 
            this.btnKonuEkle.Location = new System.Drawing.Point(191, 139);
            this.btnKonuEkle.Name = "btnKonuEkle";
            this.btnKonuEkle.Size = new System.Drawing.Size(98, 37);
            this.btnKonuEkle.TabIndex = 9;
            this.btnKonuEkle.Text = "Konu Ekle";
            this.btnKonuEkle.UseVisualStyleBackColor = true;
            this.btnKonuEkle.Click += new System.EventHandler(this.btnKonuEkle_Click);
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(291, 84);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(121, 24);
            this.cmbDers.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ders Adı:";
            // 
            // KonularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.txtkonu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKonuEkle);
            this.Name = "KonularForm";
            this.Text = "KonularForm";
            this.Load += new System.EventHandler(this.KonularForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKonuEkle;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.Label label2;
    }
}