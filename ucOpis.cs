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
            string sql = "SELECT  ";
            sql += "ar.id, cl.localitate";
            sql += ", pers.tip";
            sql += ", ar.volum";
            sql += ", ar.pozitie";
            sql += ", CASE  ";
            sql += "WHEN pers.tip IN (1,2) THEN CONCAT_WS(' ', pf.nume, pf.initiala, pf.prenume) ";
            sql += "WHEN pers.tip IN (3,4) THEN CONCAT_WS(' ', pj.denumire, fo.abreviere) ";
            sql += "END AS titular ";
            sql += "FROM adrese_roluri ar ";
            sql += "INNER JOIN persoane pers ";
            sql += "ON ar.id_persoana = pers.id ";
            sql += "INNER JOIN cfg_localitati cl  ";
            sql += "ON ar.cod_cfg_localitati = cl.cod ";
            sql += "LEFT JOIN persoane_fizice pf  ";
            sql += "ON pers.id_persoana = pf.id AND pers.tip IN (1,2) ";
            sql += "LEFT JOIN persoane_juridice pj  ";
            sql += "ON pers.id_persoana = pj.id AND pers.tip IN (3,4) ";
            sql += "LEFT JOIN cfg_forme_organizare AS fo ";
            sql += "ON pj.cod_forma_organizare = fo.cod ";
            sql += "ORDER BY  cl.localitate, pers.tip, ar.volum, ar.pozitie;";
            Debug.WriteLine(sql);


            BazaDeDate.ExecutaQuery(sql, null, reader =>
            {
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader.GetGuid("id").ToString(),
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
            sql += " ar.id AS id_pozitie";
            sql += ", cl.cod AS cod_localitate";
            sql += ", ar.cod_cfg_exploatatii AS cod_exploatate";
            sql += ", pers.tip AS tip_gospodarie";
            sql += ", ar.volum";
            sql += ", ar.pozitie";
            sql += ", ar.id_adresa_rol AS id_adresa_pozitie";
            sql += ", pers.id AS id_persoane";
            sql += ", pers.id_persoana AS id_persoana";
            sql += ", COALESCE(adr_pf.tip, adr_pj.tip) AS tip_adresa_persoana";
            sql += ", COALESCE(adr_pf.id, adr_pj.id) AS id_adresa_persoana";
            sql += " FROM adrese_roluri ar";
            sql += " INNER JOIN persoane pers";
            sql += " ON ar.id_persoana = pers.id";
            sql += " INNER JOIN cfg_localitati cl";
            sql += " ON ar.cod_cfg_localitati = cl.cod";
            sql += " LEFT JOIN persoane_fizice pf";
            sql += " ON pers.id_persoana = pf.id AND pers.tip IN (1,2)";
            sql += " LEFT JOIN persoane_juridice pj";
            sql += " ON pers.id_persoana = pj.id AND pers.tip IN (3,4)";
            sql += " LEFT JOIN adrese adr_pf";
            sql += " ON adr_pf.id = pf.id_adrese";
            sql += " LEFT JOIN adrese adr_pj";
            sql += " ON adr_pj.id = pj.id_adrese";
            sql += " WHERE ar.id = @id_rol;";

            var param = new List<MySqlParameter>
            {
                //Guid.Parse(reader.GetString("id_pozitie"))
                new MySqlParameter("@id_rol", Guid.Parse( dataGridView1.SelectedRows[0].Cells[0].Value.ToString())),
            };

            //sql += " WHERE ar.id = '" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "';";

            Debug.WriteLine(sql);

            BazaDeDate.ExecutaQuery(sql, param, reader =>
            {
                var str = "\r\n" + "id pozitie: " + reader.GetGuid("id_pozitie") + "\r\n"; 
                str += "cod localitate: " + reader.GetInt32("cod_localitate") + "\r\n";
                str += "cod exploatate: " + reader.GetInt32("cod_exploatate") + "\r\n";
                str += "tip gospodarie: " + reader.GetInt32("tip_gospodarie") + "\r\n";
                str += "volum: " + reader.GetInt32("volum") + "\r\n";
                str += "pozitie: " + reader.GetInt32("pozitie") + "\r\n";
                str += "id_adresa_pozitie: " + reader.GetGuid("id_adresa_pozitie") + "\r\n";
                str += "id persoane: " + reader.GetGuid("id_persoane") + "\r\n";
                str += "id persoana: " + reader.GetGuid("id_persoana") + "\r\n";
                str += "tip adresa persoana: " + reader.GetString("tip_adresa_persoana") + "\r\n";
                str += "id adresa persoana: " + reader.GetGuid("id_adresa_persoana") + "\r\n";
                
                Debug.WriteLine(str);
                Program.ucPozitie.textBox1.Text = str;
                str = string.Empty;
            });
        }

    }
}
