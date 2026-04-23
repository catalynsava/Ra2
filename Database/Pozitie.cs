using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ra.Database
{
    public class CfgLocalitate
    {
        public int? Cod { get; set; }
        public string Denumire { get; set; }
        public string CodSiruta { get; set; }
        public string CodPostal { get; set; }
    }
    public class TipPozitie
    {
        public int? Cod { get; set; }
        public string Descriere { get; set; }
    }
    public class Exploatatie
    {
        public int? Cod { get; set; }
        public string Descriere { get; set; }
    }
    public class FormaDeOrganizare
    {
        public int? Cod { get; set; }
        public string Abreviere { get; set; }
        public string Descriere { get; set; }
    }
    public class Adresa
    {
        public string Id { get; set; }
        public string Tip { get; set; }
        public string Judet { get; set; }
        public string Localitate { get; set; }
        public string Zona { get; set; }
        public string Strada { get; set; }
        public int? Numar { get; set; }
        public string Litera { get; set; }
        public string Bloc { get; set; }
        public string Scara { get; set; }
        public string Etaj { get; set; }
        public string Apartament { get; set; }
        public string CodPostal { get; set; }
        public string CodSiruta { get; set; }
    }
    public class PersoanaFizica : Persoana
    {
        public string Id { get; set; }
        public string Cnp { get; set; }
        public int? Sex { get; set; }
        public DateTime? DataNasterii { get; set; }
        public string Nume { get; set; }
        public string Initiala { get; set; }
        public string Prenume { get; set; }
        public string Buletin { get; set; }
        
    }
    public class PersoanaJuridica : Persoana
    {
        public string Id { get; set; }
        public FormaDeOrganizare FormaDeOrganizare { get; set; }
        public string NumePersoanaJuridica { get; set; }
        public string Filiala { get; set; }
        public string Cif { get; set; }
        public string Cui { get; set; }
        public string RegistrulComertului { get; set; }
        public string NumeReprezentant { get; set; }
        public string IntialaReprezenant { get; set; }
        public string PrenumeReprezentant { get; set; }
        public string Functia { get; set; }
    }
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(PersoanaFizica), "fizica")]
    [JsonDerivedType(typeof(PersoanaJuridica), "juridica")]
    public abstract class Persoana
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public Adresa Adresa { get; set; }
    }
    
    public class Rol
    {
        public string Id { get; set; }
        public CfgLocalitate CfgLocalitate { get; set; }
        public TipPozitie TipPozitie { get; set; }
        public int? Volum { get; set; }
        public int? Pozitie { get; set; }
        public Adresa Adresa { get; set; }
        public Exploatatie Exploatatie { get; set; }
        public Persoana Persoana { get; set; }
        public string RolImpozite { get; set; }
        public DateTime? DataDeclaratie { get; set; }
        public string NrInregistrare { get; set; }
        public DateTime? DataInregistrare { get; set; }
        public bool Semnat { get; set; }
        public bool Anulat { get; set; }
    }
}
    