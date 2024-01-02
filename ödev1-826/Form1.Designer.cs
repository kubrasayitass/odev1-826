namespace ödev1_826
{
    partial class Form1
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblBuyuk = new System.Windows.Forms.Label();
            this.lblKucuk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(40, 51);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblBuyuk
            // 
            this.lblBuyuk.AutoSize = true;
            this.lblBuyuk.Location = new System.Drawing.Point(53, 90);
            this.lblBuyuk.Name = "lblBuyuk";
            this.lblBuyuk.Size = new System.Drawing.Size(51, 13);
            this.lblBuyuk.TabIndex = 1;
            this.lblBuyuk.Text = "en büyük";
            // 
            // lblKucuk
            // 
            this.lblKucuk.AutoSize = true;
            this.lblKucuk.Location = new System.Drawing.Point(53, 124);
            this.lblKucuk.Name = "lblKucuk";
            this.lblKucuk.Size = new System.Drawing.Size(52, 13);
            this.lblKucuk.TabIndex = 2;
            this.lblKucuk.Text = "en küçük";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKucuk);
            this.Controls.Add(this.lblBuyuk);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblBuyuk;
        private System.Windows.Forms.Label lblKucuk;
    }
}

