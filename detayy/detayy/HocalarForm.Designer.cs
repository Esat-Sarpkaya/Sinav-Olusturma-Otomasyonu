namespace detayy
{
    partial class HocalarForm
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
            this.txthoca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHocaEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txthoca
            // 
            this.txthoca.Location = new System.Drawing.Point(187, 49);
            this.txthoca.Name = "txthoca";
            this.txthoca.Size = new System.Drawing.Size(100, 22);
            this.txthoca.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hoca Adı:";
            // 
            // btnHocaEkle
            // 
            this.btnHocaEkle.Location = new System.Drawing.Point(140, 96);
            this.btnHocaEkle.Name = "btnHocaEkle";
            this.btnHocaEkle.Size = new System.Drawing.Size(98, 37);
            this.btnHocaEkle.TabIndex = 3;
            this.btnHocaEkle.Text = "Hoca Ekle";
            this.btnHocaEkle.UseVisualStyleBackColor = true;
            this.btnHocaEkle.Click += new System.EventHandler(this.btnHocaEkle_Click);
            // 
            // HocalarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 191);
            this.Controls.Add(this.txthoca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHocaEkle);
            this.Name = "HocalarForm";
            this.Text = "HocalarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthoca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHocaEkle;
    }
}