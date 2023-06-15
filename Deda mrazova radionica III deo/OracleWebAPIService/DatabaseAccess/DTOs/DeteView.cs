using DatabaseAccess.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class DeteView
    {
        public int ID { get; set; }
        public  string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public string Drzava { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public  IList<PismoView> Pisma { get; set; }
        public IList<DeteRoditeljView> Roditelji { get; set; }

        public DeteView() {

            Pisma = new List<PismoView>();
            Roditelji = new List<DeteRoditeljView>();
        }

        public DeteView(Dete d)
        {
            ID = d.ID;
            Ime = d.Ime;
            Prezime = d.Prezime;
            Adresa = d.Adresa;
            Grad = d.Grad;
            Drzava = d.Drzava;
            DatumRodjenja = d.DatumRodjenja;
            Pisma = new List<PismoView>();
            Roditelji = new List<DeteRoditeljView>();
        }
    }
}
