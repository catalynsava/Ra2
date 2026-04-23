using MySqlConnector;
using Ra.Database;
using System.Diagnostics;
using System.Text.Json;

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
            sql += "ar.id";
            sql += ", cl.denumire";
            sql += ", ar.tip";
            sql += ", ar.volum";
            sql += ", ar.pozitie";
            sql += ", CASE  ";
            sql += "WHEN ar.tip IN (1,2) THEN CONCAT_WS(' ', pf.nume, pf.initiala, pf.prenume) ";
            sql += "WHEN ar.tip IN (3,4) THEN CONCAT_WS(' ', pj.denumire, fo.abreviere) ";
            sql += "END AS titular ";
            sql += "FROM adrese_roluri ar ";
            sql += "INNER JOIN persoane pers ";
            sql += "ON ar.id_persoana = pers.id ";
            sql += "INNER JOIN cfg_localitati cl  ";
            sql += "ON ar.cod_cfg_localitati = cl.cod ";
            sql += "LEFT JOIN persoane_fizice pf  ";
            sql += "ON pers.id_persoana = pf.id AND ar.tip IN (1,2) ";
            sql += "LEFT JOIN persoane_juridice pj  ";
            sql += "ON pers.id_persoana = pj.id AND ar.tip IN (3,4) ";
            sql += "LEFT JOIN cfg_forme_organizare AS fo ";
            sql += "ON pj.cod_forma_organizare = fo.cod ";
            sql += "ORDER BY  cl.denumire, ar.tip, ar.volum, ar.pozitie;";
            Debug.WriteLine(sql);


            BazaDeDate.ExecutaQuery(sql, null, reader =>
            {
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader.GetGuid("id").ToString(),
                        reader.GetString("titular"),
                        reader.GetString("denumire"),
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
            string sql = string.Empty;
            Program.ucStatus.labelIdRol.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if(dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "1"){
                Debug.WriteLine("tip = 1");
            }
            switch (dataGridView1.SelectedRows[0].Cells[3].Value.ToString())
            {
                case "1":
                case "2":
                    sql = "SELECT  rol.id";
                    sql += ", rol.cod_cfg_localitati AS cod_localitate";
                    sql += ", cfg_localitati.denumire AS denumire_localitate";
                    sql += ", cfg_localitati.cod_siruta";
                    sql += ", rol.tip AS cod_tip";
                    sql += ", cfg_tip_roluri.descriere AS descriere_tip";
                    sql += ", rol.cod_cfg_exploatatii AS cod_exploatatie";
                    sql += ", cfg_exploatatii.descriere as descriere_exploatatie";
                    sql += ", rol.volum";
                    sql += ", rol.pozitie";
                    sql += ", rol.id_adresa_rol";
                    sql += ", adrrol.tip";
                    sql += ", adrrol.judet";
                    sql += ", adrrol.localitate";
                    sql += ", adrrol.zona";
                    sql += ", adrrol.strada";
                    sql += ", adrrol.numar";
                    sql += ", adrrol.litera";
                    sql += ", adrrol.bloc";
                    sql += ", adrrol.scara";
                    sql += ", adrrol.etaj";
                    sql += ", adrrol.apartament";
                    sql += ", adrrol.cod_postal";
                    sql += ", adrrol.cod_siruta";
                    sql += ", pers.id_persoana";
                    sql += ", pf.cnp";
                    sql += ", pf.nume";
                    sql += ", pf.initiala";
                    sql += ", pf.prenume";
                    sql += ", pf.sex";
                    sql += ", pf.data_nasterii";
                    sql += ", pf.email";
                    sql += ", pf.telefon";
                    sql += ", pf.buletin";
                    sql += ", pf.id_adrese AS id_adresa_pf";
                    sql += ", adrpf.judet as pf_judet";
                    sql += ", adrpf.localitate as pf_localitate";
                    sql += ", adrpf.zona as pf_zona";
                    sql += ", adrpf.strada as pf_strada";
                    sql += ", adrpf.numar as pf_numar";
                    sql += ", adrpf.litera as pf_litera";
                    sql += ", adrpf.bloc as pf_bloc";
                    sql += ", adrpf.scara as pf_scara";
                    sql += ", adrpf.etaj as pf_etaj";
                    sql += ", adrpf.apartament as pf_apartament";
                    sql += ", adrpf.cod_postal as pf_cod_postal";
                    sql += ", adrpf.cod_siruta as pf_cod_siruta";
                    sql += " FROM adrese_roluri rol";
                    sql += " INNER JOIN adrese adrrol ON rol.id_adresa_rol = adrrol.id";
                    sql += " INNER JOIN persoane pers ON rol.id_persoana = pers.id";
                    sql += " INNER JOIN persoane_fizice pf ON pers.id_persoana = pf.id";
                    sql += " INNER JOIN adrese adrpf ON pf.id_adrese = adrpf.id";
                    sql += " INNER JOIN cfg_tip_roluri ON rol.tip = cfg_tip_roluri.cod";
                    sql += " INNER JOIN cfg_localitati ON rol.cod_cfg_localitati = cfg_localitati.cod";
                    sql += " INNER JOIN cfg_exploatatii ON rol.cod_cfg_exploatatii = cfg_exploatatii.cod";
                    sql += " WHERE rol.id = @id_rol;";
                    Debug.WriteLine(sql);
                    break;
                case "3":
                case "4":
                    sql = "SELECT ";
                    sql += "	rol.id";

                    sql += "	, rol.cod_cfg_localitati AS cod_localitate";
                    sql += "	, cfg_localitati.denumire AS denumire_localitate";
                    sql += "	, cfg_localitati.cod_siruta";

                    sql += "	, rol.tip AS cod_tip";
                    sql += "	, cfg_tip_roluri.descriere AS descriere_tip";

                    sql += "	, rol.cod_cfg_exploatatii AS cod_exploatatie";
                    sql += "	, cfg_exploatatii.descriere AS descriere_exploatatie";

                    sql += "	, rol.volum";
                    sql += "	, rol.pozitie";

                    sql += "	, rol.id_adresa_rol";
                    sql += "	, adrrol.tip";
                    sql += "	, adrrol.judet";
                    sql += "	, adrrol.localitate";
                    sql += "	, adrrol.zona";
                    sql += "	, adrrol.strada";
                    sql += "	, adrrol.numar";
                    sql += "	, adrrol.litera";
                    sql += "	, adrrol.bloc";
                    sql += "	, adrrol.scara";
                    sql += "	, adrrol.etaj";
                    sql += "	, adrrol.apartament";
                    sql += "	, adrrol.cod_postal";
                    sql += "	, adrrol.cod_siruta";

                    sql += "	, pj.cod_forma_organizare";
                    sql += "	, cfg_forme_organizare.abreviere";
                    sql += "	, cfg_forme_organizare.descriere";

                    sql += "	, pers.id_persoana";
                    sql += "	, pj.denumire AS denumirePj";
                    sql += "	, pj.filiala";
                    sql += "	, pj.cif";
                    sql += "	, pj.cui";
                    sql += "	, pj.registrul_comertului";
                    sql += "	, pj.nume_reprezentant";
                    sql += "	, pj.intiala_reprezenant";
                    sql += "	, pj.prenume_reprezentant";
                    sql += "	, pj.functia";
                    sql += "	, pj.email";
                    sql += "	, pj.telefon";

                    sql += "	, pj.id_adrese AS id_adresa_pj";
                    sql += "	, adrpj.judet AS pj_judet";
                    sql += "	, adrpj.localitate AS pj_localitate";
                    sql += "	, adrpj.zona AS pj_zona";
                    sql += "	, adrpj.strada AS pj_strada";
                    sql += "	, adrpj.numar AS pj_numar";
                    sql += "	, adrpj.litera AS pj_litera";
                    sql += "	, adrpj.bloc AS pj_bloc";
                    sql += "	, adrpj.scara AS pj_scara";
                    sql += "	, adrpj.etaj AS pj_etaj";
                    sql += "	, adrpj.apartament AS pj_apartament";
                    sql += "	, adrpj.cod_postal AS pj_cod_postal";
                    sql += "	, adrpj.cod_siruta AS pj_cod_siruta ";

                    sql += " FROM adrese_roluri rol";
                    sql += " INNER JOIN adrese adrrol ON rol.id_adresa_rol = adrrol.id";
                    sql += " INNER JOIN persoane pers ON rol.id_persoana = pers.id";
                    sql += " INNER JOIN persoane_juridice pj ON pers.id_persoana = pj.id";
                    sql += " INNER JOIN adrese adrpj ON pj.id_adrese = adrpj.id";
                    sql += " INNER JOIN cfg_tip_roluri ON rol.tip = cfg_tip_roluri.cod ";
                    sql += " INNER JOIN cfg_localitati ON rol.cod_cfg_localitati = cfg_localitati.cod";
                    sql += " INNER JOIN cfg_exploatatii ON rol.cod_cfg_exploatatii = cfg_exploatatii.cod";
                    sql += " INNER JOIN cfg_forme_organizare ON pj.cod_forma_organizare = cfg_forme_organizare.cod";
                    sql += " WHERE rol.id = @id_rol;";
                    Debug.WriteLine(sql);
                    break;
                default:
                    Debug.WriteLine("pt pf localnice");
                    break;
            }

            var param = new List<MySqlParameter>
            {
                new MySqlParameter("@id_rol", Guid.Parse( dataGridView1.SelectedRows[0].Cells[0].Value.ToString())),
            };

            Debug.WriteLine(sql);
            Program.rol =new Rol();
            BazaDeDate.ExecutaQuery(sql, param, reader =>
            {
                Program.rol.Id = reader.GetGuid("id").ToString();
                Program.rol.CfgLocalitate = new CfgLocalitate
                {
                    Cod = reader.GetInt32("cod_localitate"),
                    Denumire = reader.GetString("denumire_localitate"),
                    CodPostal = reader.GetString("cod_postal"),
                    CodSiruta = reader.GetString("cod_siruta")
                };
                Program.rol.TipPozitie = new TipPozitie { 
                    Cod = reader.GetInt32("cod_tip"),
                    Descriere = reader.GetString("descriere_tip")
                };
                Program.rol.Exploatatie = new Exploatatie
                {
                    Cod = reader.GetInt32("cod_exploatatie"),
                    Descriere = reader.GetString("descriere_exploatatie")
                };
                Program.rol.Volum = reader.GetInt32("volum");
                Program.rol.Pozitie = reader.GetInt32("pozitie");
                Program.rol.Adresa = new Adresa
                {
                    Id = reader.GetGuid("id").ToString(),
                    Tip = reader.GetString("tip"),
                    Judet = reader.GetString("judet"),
                    Localitate = reader.GetString("localitate"),
                    Zona = reader.GetString("zona"),
                    Strada = reader.GetString("strada"),
                    Numar = reader.GetInt32("numar"),
                    Litera = reader.GetString("litera"),
                    Bloc = reader.GetString("bloc"),
                    Scara = reader.GetString("scara"),
                    Etaj = reader.GetString("etaj"),
                    Apartament = reader.GetString("apartament"),
                    CodPostal = reader.GetString("cod_postal"),
                    CodSiruta = reader.GetString("cod_siruta")
                };
                if (Program.rol.TipPozitie.Cod == 1 || Program.rol.TipPozitie.Cod == 2)
                {
                    var ordinal = reader.GetOrdinal("data_nasterii");
                    Program.rol.Persoana = new PersoanaFizica
                    {
                        Id = reader.IsDBNull(reader.GetOrdinal("id_persoana")) ? "" : reader.GetGuid("id_persoana").ToString(),
                        Cnp = reader.GetString("cnp"),
                        Sex = reader.GetInt32("sex"),
                        DataNasterii = reader.IsDBNull(ordinal) ? null : reader.GetDateTime(ordinal),
                        Nume = reader.GetString("cnp"),
                        Initiala = reader.GetString("initiala"),
                        Prenume = reader.GetString("prenume"),
                        Buletin = reader.GetString("buletin"),
                        Email = reader.GetString("email"),
                        Telefon = reader.GetString("telefon"),
                        Adresa = new Adresa
                        {
                            Id = reader.IsDBNull(reader.GetOrdinal("id_adresa_pf")) ? "" : reader.GetGuid("id_adresa_pf").ToString(),
                            Judet = reader.IsDBNull(reader.GetOrdinal("pf_judet")) ? "" : reader.GetString("pf_judet"),
                            Localitate = reader.IsDBNull(reader.GetOrdinal("pf_localitate")) ? "" : reader.GetString("pf_localitate"),
                            Zona = reader.IsDBNull(reader.GetOrdinal("pf_zona")) ? "" : reader.GetString("pf_zona"),
                            Strada = reader.IsDBNull(reader.GetOrdinal("pf_strada")) ? ""  : reader.GetString(reader.GetOrdinal("pf_strada")),
                            Numar = reader.IsDBNull(reader.GetOrdinal("pf_numar")) ? null : reader.GetInt32(reader.GetOrdinal("pf_numar")),
                            Litera = reader.IsDBNull(reader.GetOrdinal("pf_litera")) ? "" : reader.GetString(reader.GetOrdinal("pf_litera")),
                            Bloc = reader.IsDBNull(reader.GetOrdinal("pf_bloc")) ? "" : reader.GetString(reader.GetOrdinal("pf_bloc")),
                            Scara = reader.IsDBNull(reader.GetOrdinal("pf_scara")) ? "" : reader.GetString(reader.GetOrdinal("pf_scara")),
                            Etaj = reader.IsDBNull(reader.GetOrdinal("pf_etaj")) ? "" : reader.GetString(reader.GetOrdinal("pf_etaj")),
                            Apartament = reader.IsDBNull(reader.GetOrdinal("pf_apartament")) ? "" : reader.GetString(reader.GetOrdinal("pf_apartament")),
                            CodPostal = reader.IsDBNull(reader.GetOrdinal("pf_cod_postal")) ? "" : reader.GetString(reader.GetOrdinal("pf_cod_postal")),
                            CodSiruta = reader.IsDBNull(reader.GetOrdinal("pf_cod_siruta")) ? "" : reader.GetString(reader.GetOrdinal("pf_cod_siruta"))
                        }
                    };
                }else if(Program.rol.TipPozitie.Cod == 3 || Program.rol.TipPozitie.Cod == 4){
                    Program.rol.Persoana = new PersoanaJuridica
                    {
                        Id = reader.IsDBNull(reader.GetOrdinal("id_persoana")) ? "" : reader.GetGuid(reader.GetOrdinal("id_persoana")).ToString(),
                        FormaDeOrganizare = new FormaDeOrganizare
                        {
                            Cod = reader.IsDBNull(reader.GetOrdinal("cod_forma_organizare")) ? null : reader.GetInt32(reader.GetOrdinal("cod_forma_organizare")),
                            Abreviere = reader.IsDBNull(reader.GetOrdinal("abreviere")) ? "" : reader.GetString(reader.GetOrdinal("abreviere")),
                            Descriere = reader.IsDBNull(reader.GetOrdinal("descriere")) ? "" : reader.GetString(reader.GetOrdinal("descriere"))
                        },
                        NumePersoanaJuridica = reader.IsDBNull(reader.GetOrdinal("denumirePj")) ? "" : reader.GetString(reader.GetOrdinal("denumirePj")),
                        Filiala = reader.IsDBNull(reader.GetOrdinal("filiala")) ? "" : reader.GetString(reader.GetOrdinal("filiala")),
                        Cif = reader.IsDBNull(reader.GetOrdinal("cif")) ? "" : reader.GetString(reader.GetOrdinal("cif")),
                        Cui = reader.IsDBNull(reader.GetOrdinal("cui")) ? "" : reader.GetString(reader.GetOrdinal("cui")),
                        RegistrulComertului = reader.IsDBNull(reader.GetOrdinal("registrul_comertului")) ? "" : reader.GetString(reader.GetOrdinal("nume_reprezentant")),
                        NumeReprezentant = reader.IsDBNull(reader.GetOrdinal("nume_reprezentant")) ? "" : reader.GetString(reader.GetOrdinal("nume_reprezentant")),
                        IntialaReprezenant = reader.IsDBNull(reader.GetOrdinal("intiala_reprezenant")) ? "" : reader.GetString(reader.GetOrdinal("intiala_reprezenant")),
                        PrenumeReprezentant = reader.IsDBNull(reader.GetOrdinal("prenume_reprezentant")) ? "" : reader.GetString(reader.GetOrdinal("prenume_reprezentant")),
                        Functia = reader.IsDBNull(reader.GetOrdinal("functia")) ? "" : reader.GetString(reader.GetOrdinal("functia")),
                        Email = reader.IsDBNull(reader.GetOrdinal("email")) ? "" : reader.GetString(reader.GetOrdinal("email")),
                        Telefon = reader.IsDBNull(reader.GetOrdinal("telefon")) ? "" : reader.GetString(reader.GetOrdinal("telefon")),
                        Adresa = new Adresa
                        {
                            Id = reader.IsDBNull(reader.GetOrdinal("id_adresa_pj")) ? "" : reader.GetGuid(reader.GetOrdinal("id_adresa_pj")).ToString(),
                            Judet = reader.IsDBNull(reader.GetOrdinal("pj_judet")) ? "" : reader.GetString(reader.GetOrdinal("pj_judet")),
                            Localitate = reader.IsDBNull(reader.GetOrdinal("pj_localitate")) ? "" : reader.GetString(reader.GetOrdinal("pj_localitate")),
                            Zona = reader.IsDBNull(reader.GetOrdinal("pj_zona")) ? "" : reader.GetString(reader.GetOrdinal("pj_zona")),
                            Strada = reader.IsDBNull(reader.GetOrdinal("pj_strada")) ? "" : reader.GetString(reader.GetOrdinal("pj_strada")),
                            Numar = reader.IsDBNull(reader.GetOrdinal("pj_numar")) ? null : reader.GetInt32(reader.GetOrdinal("pj_numar")),
                            Litera = reader.IsDBNull(reader.GetOrdinal("pj_litera")) ? "" : reader.GetString(reader.GetOrdinal("pj_litera")),
                            Bloc = reader.IsDBNull(reader.GetOrdinal("pj_bloc")) ? "" : reader.GetString(reader.GetOrdinal("pj_bloc")),
                            Scara = reader.IsDBNull(reader.GetOrdinal("pj_scara")) ? "" : reader.GetString(reader.GetOrdinal("pj_scara")),
                            Etaj = reader.IsDBNull(reader.GetOrdinal("pj_etaj")) ? "" : reader.GetString(reader.GetOrdinal("pj_etaj")),
                            Apartament = reader.IsDBNull(reader.GetOrdinal("pj_apartament")) ? "" : reader.GetString(reader.GetOrdinal("pj_apartament")),
                            CodPostal = reader.IsDBNull(reader.GetOrdinal("pj_cod_postal")) ? "" : reader.GetString(reader.GetOrdinal("pj_cod_postal")),
                            CodSiruta= reader.IsDBNull(reader.GetOrdinal("pj_cod_siruta")) ? "" : reader.GetString(reader.GetOrdinal("pj_cod_siruta"))
                        }
                    };
                }
                var options = new JsonSerializerOptions
                {
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    WriteIndented = true,
                    
                };
                
                var json = JsonSerializer.Serialize(Program.rol, options);
                //string json = JsonSerializer.Serialize(Program.rol);
                
                Program.ucPozitie.textBox1.Text = json;
                Program.ucPozitie.buttonTip.Text = Program.rol.TipPozitie.Descriere;
                Program.ucPozitie.buttonLocalitate.Text = Program.rol.CfgLocalitate.Denumire;
                Program.ucPozitie.buttonTipExploatatie.Text = Program.rol.Exploatatie.Descriere;
                Program.ucPozitie.textBoxVolum.Text = Program.rol.Volum.ToString();
                Program.ucPozitie.textBoxPozitie.Text = Program.rol.Pozitie.ToString();
                Program.ucPozitie.textBoxStrada.Text =  Program.rol.Adresa.Strada.ToString();
            });
        }

    }
}
