using DedaMrazovaRadionica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica
{
    public class VilenjakBasic
    {
        public int id;
        public string jedinstvenoIme;
        public string zemljaPorekla;
        public DateTime datumZaposlenja;

        public VilenjakBasic() { }
        public VilenjakBasic(int ID,string jedIme, string zemPor, DateTime datZap)
        {
            id = ID;
            jedinstvenoIme = jedIme;
            zemljaPorekla = zemPor;
            datumZaposlenja = datZap;
        }
    }

    public class VilenjakZaIrvaseBasic : VilenjakBasic
    {
        IrvasDTO irvas;
        public VilenjakZaIrvaseBasic() { }
        public VilenjakZaIrvaseBasic(int id, string jedinstvenoIme, string zemljaPorekla, DateTime datumZaposlenja, IrvasDTO irvas = null ) : base(id, jedinstvenoIme, zemljaPorekla, datumZaposlenja)
        {
            this.irvas = irvas;

        }
    }

    public class VilenjakZaIsporukuPoklonaBasic : VilenjakBasic
    {
        public VilenjakZaIsporukuPoklonaBasic() { }
        public VilenjakZaIsporukuPoklonaBasic( int id, string jedinstvenoIme, string zemljaPorekla, DateTime datumZaposlenja) : base(id, jedinstvenoIme, zemljaPorekla, datumZaposlenja)
        {

        }
    }

    public class VilenjakZaIzraduIgracakaMentor : VilenjakBasic
    {

        public VilenjakZaIzraduIgracakaMentor() { }
        public VilenjakZaIzraduIgracakaMentor(int id, string jedIme, string zemPor, DateTime datZap) : base(id, jedIme, zemPor,datZap)
        {
            
        }
    }

    public class VilenjakZaPokloneBasic :VilenjakBasic
    {
        public VilenjakZaPokloneBasic()
        {

        }
        public VilenjakZaPokloneBasic(int id, string jedIme, string zemPor, DateTime datZap): base(id, jedIme, zemPor, datZap)
        {

        }
    }

    public class VilenjakZaIzraduIgracakaBasic : VilenjakBasic
    {
        public string materijal;
        public TimID pripadaTimu;
        public int flagKoordinator;
        public DeoRadioniceID deoRadionice;
        public int flagSef;
        public int duzinaObuke;
        public int ocena;
        public VilenjakZaIzraduIgracakaMentor mentor;
        public VilenjakZaIzraduIgracakaBasic(int id,
            string jedIme, string zemPor, DateTime datZap, string materijal,
            DeoRadioniceID deoRadionice, int fs, TimID tim, int fk, int duzinaObuke, int ocena,
            VilenjakZaIzraduIgracakaMentor mentor) : base(id, jedIme, zemPor, datZap)
        {
            this.materijal = materijal;
            this.deoRadionice = deoRadionice;
            this.pripadaTimu = tim;
            this.duzinaObuke = duzinaObuke;
            this.ocena = ocena;
            this.mentor = mentor;
            this.flagSef = fs;
            this.flagKoordinator = fk;
        }
    }
    public class VilenjakZaIrvaseSaVestinama: VilenjakZaIrvaseBasic
    {
        public IList<MagicnaVestinaPrikaz> vestine;
        public IrvasDTO irvas;
        public VilenjakZaIrvaseSaVestinama(int id, string ji, string zp, DateTime dp, IList<MagicnaVestinaPrikaz> vestine, IrvasDTO irvas)
            : base(id, ji, zp, dp)
        {
            this.vestine = vestine;
            this.irvas = irvas;
        }

    }

    public class IrvasDTO
    {
        public int id;
        public string ime;
        public int starost;
        
        public IrvasDTO (int id, string ime, int starost)
        {
            this.id = id;
            this.ime = ime;
            this.starost = starost;
        }
    }

    public class DeoRadioniceID
    {
        public int id;
        public string naziv;

        public DeoRadioniceID (int id, string naziv)
        {
            this.id = id;
            this.naziv = naziv;
        }
    }

    public class TimID
    {
        public int id;
        public string naziv;

        public TimID(int id, string naziv)
        {
            this.id = id;
            this.naziv = naziv;
        }
    }

    public class VilenjakZaIzraduIgracakaSaVestinama : VilenjakZaIzraduIgracakaBasic
    {
        public IList<MagicnaVestinaPrikaz> vestine;

        public VilenjakZaIzraduIgracakaSaVestinama(int id,
            string jedIme, string zemPor, DateTime datZap, string materijal,
            DeoRadioniceID deoRadionice, int fs, TimID tim, int fk, int duzinaObuke, int ocena,
            VilenjakZaIzraduIgracakaMentor mentor, IList<MagicnaVestinaPrikaz> vestine) : base(id,
            jedIme, zemPor, datZap, materijal,
            deoRadionice, fs, tim, fk, duzinaObuke, ocena, mentor)
        {
            this.vestine = vestine;
        }
    }

    public class MagicnaVestinaPrikaz
    {
        public string naziv;
        public int id;
        public MagicnaVestinaPrikaz(string naziv, int id)
        {
            this.naziv = naziv;
            this.id = id;
        }
    }

    public class PismoPregled

    {

        public int ID;

        public string tekst;

        public float indDobrote;
        public Dete dete;


        public PismoPregled(int id, string t, float i, Dete dete)

        {

            this.ID = id;

            this.tekst = t;

            this.indDobrote = i;
            this.dete = dete;

        }

    }



    public class PismoBasic

    {

        public int ID;

        public string tekst;

        public float indDobrote;

        public DateTime datumSlanja;

        public DateTime datumPrijema;

        public Dete dete;


        public PismoBasic(int id)
        {
            this.ID = id;
        }
        public PismoBasic(int iD, string tekst, float indDobrote, DateTime datumSlanja, DateTime datumPrijema, Dete dete)

        {

            ID = iD;

            this.tekst = tekst;

            this.indDobrote = indDobrote;

            this.datumSlanja = datumSlanja;

            this.datumPrijema = datumPrijema;

            this.dete = dete;

        }

    }



    public class DeteImePrezime
    {
        public int ID;
        public string ime;
        public string prezime;

        public DeteImePrezime(int id, string ion, string prezime)
        {
            ID = id;
            this.ime = ion;
            this.prezime = prezime;
        }


    }

    public class ListaZeljaBasic

    {

        public int ID;

        public Pismo pismo;

        public ListaZeljaBasic()
        {
        }

        public ListaZeljaBasic(Pismo pismo)

        {

            this.pismo = pismo;

        }

    }

    public class TovarBasic
    {
        public int ID;
        public string Grad;

        public TovarBasic(string grad)
        {
            Grad = grad;
        }
    }

    public class PoklonBasic
    {
        public int ID;
        public string boja;
        public string posveta;
        public ListaZelja pripadaListiZelja;
        public Tovar pripadaTovaru;
        public string destinacija;
        public string dete;

        public PoklonBasic(int id, string boja, string posveta, ListaZelja lz, Tovar tovar, string destinacija, string dete)
        {
            ID = id;
            this.boja = boja;
            this.posveta = posveta;
            pripadaListiZelja = lz;
            pripadaTovaru = tovar;
            this.destinacija = destinacija;
            this.dete = dete;
        }
    }

        //------------

    public class PesmaDTO
    {
        public int ID;
        public string naziv;
        public string tekst;

        public PesmaDTO (int iD, string naziv, string tekst)
        {
            ID = iD;
            this.naziv = naziv;
            this.tekst = tekst;
        }
    }
    
    public class VilenjakZaPokloneSaVestinama : VilenjakBasic
    {
        public IList<PoklonBasic> listaPoklona;
        public IList<MagicnaVestinaPrikaz> vestine;

        public VilenjakZaPokloneSaVestinama(int id, string ime, string zemlja, DateTime dz, IList<PoklonBasic> lista, IList<MagicnaVestinaPrikaz> vestine) : base(id, ime, zemlja, dz)
        {
            this.listaPoklona = lista;
            this.vestine = vestine;
        }
    }

    public class VilenjakZaIsporukuPoklonaSaVestinama : VilenjakBasic
    {
        TovarBasic tovar;

        public VilenjakZaIsporukuPoklonaSaVestinama(int id, string ime, string zemlja, DateTime dz, TovarBasic tovari) : base(id, ime, zemlja, dz)
        {
            this.tovar = tovari;
        }
    }

    public class IgrackaPregled
    {
        public int ID;
        public int redniBroj;
        public string tip;
        public string opis;
        public Poklon pripadaPoklonu;
        public DeoRadionice izradjenaUDeluRadionice;
        public ListaZelja pripadaListiZelja;
        public VilenjakZaIzraduIgracaka vilenjak;


        public IgrackaPregled(int redniBroj, string tip, string opis, Poklon pripadaPoklonu, DeoRadionice izradjenaUDeluRadionice, ListaZelja pripadaListiZelja, VilenjakZaIzraduIgracaka vilenjak)
        {
            this.redniBroj = redniBroj;
            this.tip = tip;
            this.opis = opis;
            this.pripadaPoklonu = pripadaPoklonu;
            this.izradjenaUDeluRadionice = izradjenaUDeluRadionice;
            this.pripadaListiZelja = pripadaListiZelja;
            this.vilenjak = vilenjak;
        }
    }
    public class VilenjakZaIzraduIgracakaPoklon : VilenjakBasic
    {
        public string materijal;
        public TimID pripadaTimu;
        public DeoRadionice deoRadionice;
        public int duzinaObuke;
        public int ocena;
        public VilenjakZaIzraduIgracakaMentor mentor;
        public VilenjakZaIzraduIgracakaPoklon(int id,
            string jedIme, string zemPor, DateTime datZap, string materijal,
            DeoRadionice deoRadionice, TimID tim, int duzinaObuke, int ocena,
            VilenjakZaIzraduIgracakaMentor mentor) : base(id, jedIme, zemPor, datZap)
        {
            this.materijal = materijal;
            this.deoRadionice = deoRadionice;
            this.pripadaTimu = tim;
            this.duzinaObuke = duzinaObuke;
            this.ocena = ocena;
            this.mentor = mentor;
        }
    }
}

