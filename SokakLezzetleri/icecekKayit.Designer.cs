
namespace SokakLezzetleri
{
    partial class icecekKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxIcecekAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.mtBoxSatisFiyati = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "İÇECEĞİN ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "SATIŞ FİYATI:";
            // 
            // tBoxIcecekAdi
            // 
            this.tBoxIcecekAdi.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxIcecekAdi.Location = new System.Drawing.Point(295, 70);
            this.tBoxIcecekAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxIcecekAdi.Name = "tBoxIcecekAdi";
            this.tBoxIcecekAdi.Size = new System.Drawing.Size(281, 40);
            this.tBoxIcecekAdi.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Location = new System.Drawing.Point(414, 124);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(162, 95);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // mtBoxSatisFiyati
            // 
            this.mtBoxSatisFiyati.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold);
            this.mtBoxSatisFiyati.Location = new System.Drawing.Point(295, 141);
            this.mtBoxSatisFiyati.Name = "mtBoxSatisFiyati";
            this.mtBoxSatisFiyati.Size = new System.Drawing.Size(110, 42);
            this.mtBoxSatisFiyati.TabIndex = 12;
            this.mtBoxSatisFiyati.ValidatingType = typeof(int);
            this.mtBoxSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtBoxSatisFiyati_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(25, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "EĞER İÇECEK KAYITLI DEĞİLSE KAYIT ETSİN";
            // 
            // icecekKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 267);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtBoxSatisFiyati);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tBoxIcecekAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "icecekKayit";
            this.Text = "İÇECEK KAYIT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxIcecekAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.MaskedTextBox mtBoxSatisFiyati;
        private System.Windows.Forms.Label label3;
    }
}

