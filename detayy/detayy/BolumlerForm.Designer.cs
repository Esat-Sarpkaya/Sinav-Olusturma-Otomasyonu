namespace detayy
{
    partial class BolumlerForm
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
            this.components = new System.ComponentModel.Container();
            this.bölümlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtbolum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.cmbFakulte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bölümlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bölümlerBindingSource
            // 
            this.bölümlerBindingSource.DataMember = "Bölümler";
            // 
            // txtbolum
            // 
            this.txtbolum.Location = new System.Drawing.Point(161, 86);
            this.txtbolum.Name = "txtbolum";
            this.txtbolum.Size = new System.Drawing.Size(100, 22);
            this.txtbolum.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bölüm Adı:";
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.Location = new System.Drawing.Point(208, 133);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(98, 37);
            this.btnBolumEkle.TabIndex = 3;
            this.btnBolumEkle.Text = "Bölüm Ekle";
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // cmbFakulte
            // 
            this.cmbFakulte.FormattingEnabled = true;
            this.cmbFakulte.Location = new System.Drawing.Point(343, 83);
            this.cmbFakulte.Name = "cmbFakulte";
            this.cmbFakulte.Size = new System.Drawing.Size(121, 24);
            this.cmbFakulte.TabIndex = 6;
            this.cmbFakulte.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = " Fakülte";
            // 
            // BolumlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 243);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFakulte);
            this.Controls.Add(this.txtbolum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBolumEkle);
            this.Name = "BolumlerForm";
            this.Text = "BolumlerForm";
            this.Load += new System.EventHandler(this.BolumlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bölümlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.BindingSource bölümlerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtbolum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.ComboBox cmbFakulte;
        private System.Windows.Forms.Label label2;
    }
}