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
    public partial class icecekSatis : Form
    {
        public icecekSatis()
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
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(komut))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            da.Fill(ds,"icecekler");
                            dataGridView1.DataSource = ds.Tables["icecekler"];

                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                if (dataGridView1.Columns[i].HeaderText != "ad")
                                {
                                    dataGridView1.Columns[i].Visible = false;
                                }
                            }
                            
                            
                        }
                    }
                }
            }
        }
    }
}
