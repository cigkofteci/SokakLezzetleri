
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
            this.tBoxSatisFiyati = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "İÇECEĞİN ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "SATIŞ FİYATI:";
            // 
            // tBoxIcecekAdi
            // 
            this.tBoxIcecekAdi.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxIcecekAdi.Location = new System.Drawing.Point(262, 84);
            this.tBoxIcecekAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBoxIcecekAdi.Name = "tBoxIcecekAdi";
            this.tBoxIcecekAdi.Size = new System.Drawing.Size(76, 34);
            this.tBoxIcecekAdi.TabIndex = 2;
            // 
            // tBoxSatisFiyati
            // 
            this.tBoxSatisFiyati.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSatisFiyati.Location = new System.Drawing.Point(262, 143);
            this.tBoxSatisFiyati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBoxSatisFiyati.Name = "tBoxSatisFiyati";
            this.tBoxSatisFiyati.Size = new System.Drawing.Size(76, 34);
            this.tBoxSatisFiyati.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 77);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // icecekKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBoxSatisFiyati);
            this.Controls.Add(this.tBoxIcecekAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "icecekKayit";
            this.Text = "İÇECEK KAYIT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxIcecekAdi;
        private System.Windows.Forms.TextBox tBoxSatisFiyati;
        private System.Windows.Forms.Button button1;
    }
}

