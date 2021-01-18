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
            dbIslemleri();
        }

        SQLiteConnection baglanti = new SQLiteConnection(@"Data Source=E:\repos\SokakLezzetleri\SokakLezzetleri\database\SokakLezzetleri.db");
    
        void dbIslemleri()
        {
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("select * from icecek", baglanti);
            SQLiteDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cBoxIcecekAdi.Items.Add(read["ad"]);
            }
        }
        
    }
}
