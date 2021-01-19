using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SokakLezzetleri
{
    public partial class icecekKayit : Form
    {
        public icecekKayit()
        {
            InitializeComponent();
        }

        private void mtBoxSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as MaskedTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        string dbYolu = @"Data Source=E:\repos\SokakLezzetleri\SokakLezzetleri\database\SokakLezzetleri.db";    // ('gazoz','2,5') 

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglanti = new SQLiteConnection(dbYolu))
            {
                baglanti.Open();

                string sql = "INSERT into icecek (ad,satis_fiyati) VALUES ('"
                    + tBoxIcecekAdi.Text + "','" + mtBoxSatisFiyati.Text + "')";

                using (SQLiteCommand komut = new SQLiteCommand(sql, baglanti))
                {
                    komut.ExecuteNonQuery();
                }
            }
        }
    }
}
