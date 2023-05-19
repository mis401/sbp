﻿using DedaMrazovaRadionica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public VilenjakZaIrvaseBasic() { }
        public VilenjakZaIrvaseBasic(int id, string jedinstvenoIme, string zemljaPorekla, DateTime datumZaposlenja) : base(id,jedinstvenoIme, zemljaPorekla, datumZaposlenja)
        {
            
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
        public Tim pripadaTimu;
        public DeoRadionice deoRadionice;
        public int duzinaObuke;
        public int ocena;
        public VilenjakZaIzraduIgracaka mentor;
        public VilenjakZaIzraduIgracakaBasic(int id,
            string jedIme, string zemPor, DateTime datZap, string materijal,
            DeoRadionice deoRadionice, Tim tim, int duzinaObuke, int ocena,
            VilenjakZaIzraduIgracaka mentor) : base(id, jedIme, zemPor, datZap)
        {
            this.materijal = materijal;
            this.deoRadionice = deoRadionice;
            this.pripadaTimu = tim;
            this.duzinaObuke = duzinaObuke;
            this.ocena = ocena;
            this.mentor = mentor;
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

    public class PismoPregled
    {
        public int ID;
        public string tekst;
        public float indDobrote;
        
        public PismoPregled(int id, string t, float i)
        {
            this.ID = id;
            this.tekst = t;
            this.indDobrote = i;
        }
    }

    public class PismoBasic
    {
        public int ID;
        public string tekst;
        public float indDobrote;
        public DateTime datumSlanja;
        public DateTime datumPrijema;
        public DeteBasic dete;

        public PismoBasic(int iD, string tekst, float indDobrote, DateTime datumSlanja, DateTime datumPrijema, DeteBasic dete)
        {
            ID = iD;
            this.tekst = tekst;
            this.indDobrote = indDobrote;
            this.datumSlanja = datumSlanja;
            this.datumPrijema = datumPrijema;
            this.dete = dete;
        }
    }

    public class DeteBasic
    {

    }
    public class ListaZeljaBasic
    {
        public int ID;
        public PismoBasic pismo;
        
        public ListaZeljaBasic(PismoBasic pismo)
        {
            this.pismo = pismo;
        }
    }
}
