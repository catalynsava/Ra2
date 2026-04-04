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
            dataGridView1.Columns[1].Name = "titular";
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[2].Name = "localitate";
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Name = "tip";
            dataGridView1.Columns[3].Width = 15;
            dataGridView1.Columns[4].Name = "volum";
            dataGridView1.Columns[4].Width = 15;
            dataGridView1.Columns[5].Name = "pozitie";
            dataGridView1.Columns[5].Width = 33;
            


            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.RowTemplate.Height = 22;

            citesteOpis();
        }

        public void citesteOpis()
        {
            /*string sql = $"SELECT ";
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
            sql += " ORDER  BY loc.localitate, rol.tip, rol.volum, rol.pozitie;";*/
            string sql = "SELECT ";
            sql += " ar.id,";
            sql += " cl.localitate,";
            sql += " ar.tip,";
            sql += " ar.volum,";
            sql += " ar.pozitie,";
            sql += " CASE ";
            sql += " WHEN ar.tip IN (1,2) THEN CONCAT_WS(' ', pf.nume, pf.initiala, pf.prenume)";
            sql += " WHEN ar.tip IN (3,4) THEN CONCAT_WS(' ', pj.denumire, fo.abreviere)";
            sql += " END AS titular";
            sql += " FROM adrese_roluri ar";
            sql += " INNER JOIN cfg_localitati cl ";
            sql += " ON ar.cod_cfg_localitati = cl.cod";
            sql += " LEFT JOIN persoane_fizice pf ";
            sql += " ON ar.id_persoana = pf.id AND ar.tip IN (1,2)";
            sql += " LEFT JOIN persoane_juridice pj ";
            sql += " ON ar.id_persoana = pj.id AND ar.tip IN (3,4)";
            sql += " LEFT JOIN cfg_forme_organizare AS fo";
            sql += " ON pj.cod_forma_organizare = fo.cod";
            sql += " ORDER BY ";
            sql += " cl.localitate,";
            sql += " ar.tip,";
            sql += " ar.volum,";
            sql += " ar.pozitie;";


            BazaDeDate.ExecutaQuery(sql, reader =>
            {
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader.GetString("id"),
                        reader.GetString("titular"),
                        reader.GetString("localitate"),
                        reader.GetInt32("tip"),
                        reader.GetInt32("volum"),
                        reader.GetInt32("pozitie")
                       );
                }
            });
            sql = "";
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Program.ucStatus.labelIdRol.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            string sql = "SELECT";
            sql += "   ar.id,";
            sql += "   CASE ";
            sql += "       WHEN ar.tip IN (1,2) THEN 'PF'";
            sql += "       WHEN ar.tip IN (3,4) THEN 'PJ'";
            sql += "   END AS tip_persoana,";
            sql += "   ar.tip,";
            sql += "   ar.cod_cfg_localitati,";
            sql += "   ar.id_adresa_rol,";
            sql += "   ar.cod_cfg_exploatatii,";
            sql += "   ar.id_persoana,";
            sql += "   COALESCE(pf.id_adrese, pj.id_adrese) AS adresa_id_persoana";
            sql += " FROM adrese_roluri ar";
            sql += " LEFT JOIN persoane_fizice pf";
            sql += "   ON ar.id_persoana = pf.id AND ar.tip IN (1,2)";
            sql += " LEFT JOIN persoane_juridice pj";
            sql += "   ON ar.id_persoana = pj.id AND ar.tip IN (3,4)";
            sql += " LEFT JOIN cfg_forme_organizare fo";
            sql += "   ON pj.cod_forma_organizare = fo.cod";
            sql += " WHERE ar.id = '" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "';";

            Debug.WriteLine(sql);

            BazaDeDate.ExecutaQuery(sql, reader =>
            {
                var str = "\r\n" + "idrol: " + reader.GetString("id") + "\r\n"
                    + "tip persoana:" + reader.GetString("tip_persoana") + "\r\n"
                    + "tip rol:" + reader.GetInt32("tip") + "\r\n"
                    + "cod localitate:" + reader.GetInt32("cod_cfg_localitati") + "\r\n"
                    + "adresa rol:" + reader.GetString("id_adresa_rol") + "\r\n"
                    + "cod exploatatie:" + reader.GetInt32("cod_cfg_exploatatii") + "\r\n"
                    + "id persoana:" + reader.GetString("id_persoana") + "\r\n"
                    + "id adresa persoana:" + reader.GetString("adresa_id_persoana") + "\r\n";
                

                Debug.WriteLine(str);
                Program.ucPozitie.textBox1.Text = str;
            });
        }

    }
}
