using MySqlConnector;
using Ra.Database;
using Ra.Design;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ra
{
    public partial class ucOpis : UserControl
    {
        public ucOpis()
        {
            InitializeComponent();

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView1.ColumnCount = 6;

            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "localitate";
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Name = "tip";
            dataGridView1.Columns[2].Width = 15;
            dataGridView1.Columns[3].Name = "volum";
            dataGridView1.Columns[3].Width = 15;
            dataGridView1.Columns[4].Name = "pozitie";
            dataGridView1.Columns[4].Width = 15;
            dataGridView1.Columns[5].Name = "titular";
            dataGridView1.Columns[5].Width = 110;


            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.RowTemplate.Height = 22;

            citesteOpis();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Program.ucStatus.label1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        public void citesteOpis()
        {
            string sql = $"SELECT ";
            sql += "rol.id";
            sql += ", loc.localitate";
            sql += ", rol.tip";
            sql += ", rol.volum";
            sql += ", rol.pozitie";
            sql += ",  COALESCE(CONCAT(pf.nume,' ',pf.prenume), pj.denumire)  AS titular";
            sql += " FROM adrese_roluri rol";
            sql += " INNER  JOIN cfg_localitati loc";
            sql += " ON rol.cod_cfg_localitati = loc.cod";
            sql += " INNER  JOIN persoane pers";
            sql += " ON rol.id_persoana = pers.id";
            sql += " LEFT  JOIN persoane_fizice pf";
            sql += " ON pers.id_persoana = pf.id";
            sql += " LEFT  JOIN persoane_juridice pj ";
            sql += " ON pers.id_persoana = pj.id";
            sql += " ORDER  BY loc.localitate, rol.tip, rol.volum, rol.pozitie;";

            Debug.WriteLine(sql);

            Conectare.ConectareDB();


            MySqlCommand opisCommand = new MySqlCommand();
            opisCommand.Connection = Program.Conexiune;
            opisCommand.CommandText = sql;

            MySqlDataReader opisReader = opisCommand.ExecuteReader();

            dataGridView1.Rows.Clear();
            while (opisReader.Read())
            {
                dataGridView1.Rows.Add(
                    opisReader.GetString("id"),
                    opisReader.GetString("localitate"),
                    opisReader.GetInt32("tip"),
                    opisReader.GetInt32("volum"),
                    opisReader.GetInt32("pozitie"),
                    opisReader.GetString("titular")
                   );
            }
            Conectare.DeconectareDB();
        }
    }
}
