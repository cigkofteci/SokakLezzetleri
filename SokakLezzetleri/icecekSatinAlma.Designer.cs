
namespace SokakLezzetleri
{
    partial class icecekSatinAlma
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
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxIcecekAdi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtBoxAlinanAdet = new System.Windows.Forms.MaskedTextBox();
            this.mtBoxOdenenFiyat = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(53, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "(TOPLAM FİYAT)";
            // 
            // cBoxIcecekAdi
            // 
            this.cBoxIcecekAdi.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold);
            this.cBoxIcecekAdi.FormattingEnabled = true;
            this.cBoxIcecekAdi.Location = new System.Drawing.Point(375, 55);
            this.cBoxIcecekAdi.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxIcecekAdi.Name = "cBoxIcecekAdi";
            this.cBoxIcecekAdi.Size = new System.Drawing.Size(365, 42);
            this.cBoxIcecekAdi.TabIndex = 7;
            this.cBoxIcecekAdi.Text = " SEÇİM YAPINIZ!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(51, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "ALINAN İÇECEK:";
            // 
            // btnAl
            // 
            this.btnAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAl.Location = new System.Drawing.Point(561, 174);
            this.btnAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(179, 110);
            this.btnAl.TabIndex = 9;
            this.btnAl.Text = "AL";
            this.btnAl.UseVisualStyleBackColor = true;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(51, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "ALINAN MİKTAR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(53, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADET CİNSİNDEN GİRİNİZ!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(51, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "ÖDENEN FİYAT:";
            // 
            // mtBoxAlinanAdet
            // 
            this.mtBoxAlinanAdet.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold);
            this.mtBoxAlinanAdet.Location = new System.Drawing.Point(375, 152);
            this.mtBoxAlinanAdet.Name = "mtBoxAlinanAdet";
            this.mtBoxAlinanAdet.Size = new System.Drawing.Size(110, 42);
            this.mtBoxAlinanAdet.TabIndex = 10;
            this.mtBoxAlinanAdet.ValidatingType = typeof(int);
            this.mtBoxAlinanAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtBoxAlinanAdet_KeyPress);
            // 
            // mtBoxOdenenFiyat
            // 
            this.mtBoxOdenenFiyat.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold);
            this.mtBoxOdenenFiyat.Location = new System.Drawing.Point(375, 231);
            this.mtBoxOdenenFiyat.Name = "mtBoxOdenenFiyat";
            this.mtBoxOdenenFiyat.Size = new System.Drawing.Size(110, 42);
            this.mtBoxOdenenFiyat.TabIndex = 11;
            this.mtBoxOdenenFiyat.ValidatingType = typeof(int);
            this.mtBoxOdenenFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtBoxOdenenFiyat_KeyPress);
            // 
            // icecekSatinAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 339);
            this.Controls.Add(this.mtBoxOdenenFiyat);
            this.Controls.Add(this.mtBoxAlinanAdet);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBoxIcecekAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "icecekSatinAlma";
            this.Text = "İÇECEK SATIN AL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxIcecekAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtBoxAlinanAdet;
        private System.Windows.Forms.MaskedTextBox mtBoxOdenenFiyat;
    }
}