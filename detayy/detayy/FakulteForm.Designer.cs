namespace detayy
{
    partial class FakulteForm
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
            this.btnFakEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfakulte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFakEkle
            // 
            this.btnFakEkle.Location = new System.Drawing.Point(128, 131);
            this.btnFakEkle.Name = "btnFakEkle";
            this.btnFakEkle.Size = new System.Drawing.Size(98, 37);
            this.btnFakEkle.TabIndex = 0;
            this.btnFakEkle.Text = "Fakülte Ekle";
            this.btnFakEkle.UseVisualStyleBackColor = true;
            this.btnFakEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fakülte Adı:";
            // 
            // txtfakulte
            // 
            this.txtfakulte.Location = new System.Drawing.Point(175, 84);
            this.txtfakulte.Name = "txtfakulte";
            this.txtfakulte.Size = new System.Drawing.Size(100, 22);
            this.txtfakulte.TabIndex = 2;
            // 
            // FakulteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 229);
            this.Controls.Add(this.txtfakulte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFakEkle);
            this.Name = "FakulteForm";
            this.Text = "FakulteForm";
            this.Load += new System.EventHandler(this.FakulteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFakEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfakulte;
    }
}