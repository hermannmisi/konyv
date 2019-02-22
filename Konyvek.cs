using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ADOX;

namespace Konyv
{
    public partial class Konyvek : Form
    {
        OleDbConnection kapcsolat = null;
        OleDbDataAdapter dTAdapter = null;
        string[] kijeloltAdatok = new string[] { "", "" };

        public Konyvek()
        {
            InitializeComponent();

            try
            {
                //kapcsolat beállítása és kísérlet a megnyitásra
                kapcsolat = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = .\\konyv.mdb");
                kapcsolat.Open();
            }
            catch
            {
                //ha a fájl nem létezik, akkor létrehozás táblákkal együtt, majd megnyitás.
                Catalog Fajl = new Catalog();
                Table tableNev = new Table();

                tableNev.Name = "Konyvek";
                tableNev.Columns.Append("Szerzo");
                tableNev.Columns.Append("Konyvcim");

                try
                {
                    Fajl.Create("provider=Microsoft.Jet.OleDb.4.0;Data Source=.\\konyv.mdb");
                    Fajl.Tables.Append(tableNev);
                }

                catch
                {

                }
                finally
                {
                    Fajl = null;
                }
                kapcsolat.Open();
            }
        }

        private void Konyvek_Load(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(this, null);
        }

        private void Konyvek_Resize(object sender, EventArgs e)
        {
            //40, 63
            tabControl1.Width = this.Width - 40;
            tabControl1.Height = this.Height - 63;
            dataGridView1.Width = tabControl1.Width - 20;
            dataGridView1.Height = tabControl1.Height - 67;
            btnTorles.Location = new Point(tabControl1.Width - 154, btnTorles.Location.Y);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            if (tabControl1.SelectedTab.Name == "Megjelenites")
            {
                dataGridView1.Columns.Clear();
                dTAdapter = new OleDbDataAdapter("SELECT * FROM Konyvek", kapcsolat);

                if (dTAdapter != null)
                {
                    dTAdapter.Fill(dataTable);
                }

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AllowUserToAddRows = false;

                dataGridView1.DataSource = dataTable;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].HeaderText = "Szerző";
                dataGridView1.Columns[1].HeaderText = "Könyv címe";
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoResizeColumns();
                dataGridView1.ClearSelection();
            }
            else
            {
                txtBxSzerzo.Text = "";
                txtBxKonyvcim.Text = "";
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kijeloltAdatok = new string[] { "", "" };

            if (e.RowIndex >= 0)
            {
                kijeloltAdatok[0] = dataGridView1.Rows[e.RowIndex].Cells["Szerzo"].Value.ToString();
                kijeloltAdatok[1] = dataGridView1.Rows[e.RowIndex].Cells["Konyvcim"].Value.ToString();
            }
        }

        private void btnAdatRogzitese_Click(object sender, EventArgs e)
        {
            if (txtBxSzerzo.Text != "" && txtBxKonyvcim.Text != "")
            {
                try
                {
                    OleDbCommand Beiras = new OleDbCommand(@"INSERT INTO Konyvek (Szerzo, Konyvcim) VALUES (""" +
                        txtBxSzerzo.Text + @""", """ + txtBxKonyvcim.Text + @""")");
                    Beiras.Connection = kapcsolat;
                    Beiras.ExecuteNonQuery();

                    MessageBox.Show("Az adatok rögzítve!");
                    txtBxSzerzo.Text = "";
                    txtBxKonyvcim.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Az adatok rögzítése nem sikerült!\n" + ex.ToString());
                }
            }
            else
            {
                if (txtBxSzerzo.Text == "" || txtBxKonyvcim.Text == "")
                    MessageBox.Show("A szerző és a könyv címe nem lehet üres!");
            }
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            if (kijeloltAdatok[0] != "")
            {
                if (MessageBox.Show("Valóban törölni kívánja a kijelölt könyvet?\nSzerző: " + kijeloltAdatok[0] + "\nKönyv címe: " + kijeloltAdatok[1], "Törlés megerősítése",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        OleDbCommand Torles = new OleDbCommand(@"DELETE FROM Konyvek WHERE Szerzo = """ + kijeloltAdatok[0] +
                            @""" and Konyvcim = """ + kijeloltAdatok[1] + @"""", kapcsolat);
                        Torles.ExecuteNonQuery();

                        kijeloltAdatok = new string[] { "", "" };
                        tabControl1_SelectedIndexChanged(this, null);
                        MessageBox.Show("A kijelölt könyv törölve lett!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A törlés nem sikerült:\n" + ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölve sor a törléshez!");
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
