using DatabaseAccess.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class PismoView
    {
        public  int ID { get; set; }
        public float IndeksDobrote { get; set; }
        public string Tekst { get; set; }
        public DateTime DatumSlanja { get; set; }
        public DateTime DatumPrijema { get; set; }
        public DeteView PripadaDetetu { get; set; }//
        public ListaZeljaView ListaZelja { get; set; }//
        public PismoView() { }
        public PismoView(Pismo p)
        {
            ID = p.ID;
            IndeksDobrote = p.IndeksDobrote;
            Tekst = p.Tekst;
            DatumSlanja = p.DatumSlanja;
            DatumPrijema = p.DatumPrijema;
            PripadaDetetu = new DeteView(p.PripadaDetetu);
           // ListaZelja = new ListaZeljaView(p.ListaZelja);
        }
    }
}
