using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
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

        string dbYolu = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\database\\SokakLezzetleri.db";

        void icecekleriCek()
        {
            using (SQLiteConnection baglanti = new SQLiteConnection("Data Source = " + dbYolu + ";Version=3;"))
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
