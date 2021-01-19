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
    public partial class icecekSatinAlma : Form
    {
        public icecekSatinAlma()
        {
            InitializeComponent();
            icecekleriCek();
        }

        string dbYolu = @"Data Source=E:\repos\SokakLezzetleri\SokakLezzetleri\database\SokakLezzetleri.db";

        void icecekleriCek()
        {
            using (SQLiteConnection baglanti = new SQLiteConnection(dbYolu))
            {
                baglanti.Open();
                using (SQLiteCommand komut = new SQLiteCommand("select * from icecek", baglanti))
                {
                    using (SQLiteDataReader read = komut.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            cBoxIcecekAdi.Items.Add(read["ad"]);
                        }
                    }
                }
            }
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglanti = new SQLiteConnection(dbYolu))
            {
                baglanti.Open();
                string sql = "insert into icecek_alim (icecek_id, alinan_adet ,odenen_fiyat,alim_tarihi) values (" 
                    + (cBoxIcecekAdi.SelectedIndex + 1) + "," + Convert.ToInt32(mtBoxAlinanAdet.Text) 
                    + ",'" + mtBoxOdenenFiyat.Text + "','" +DateTime.Now.ToString() +"')";
                using (SQLiteCommand komut = new SQLiteCommand(sql, baglanti))
                {
                    komut.ExecuteNonQuery();
                }
            }
        }

        private void mtBoxOdenenFiyat_KeyPress(object sender, KeyPressEventArgs e)
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

        private void mtBoxAlinanAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
