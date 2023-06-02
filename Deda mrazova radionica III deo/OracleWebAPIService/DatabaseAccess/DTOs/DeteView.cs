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
        public  IList<PismoView> Pisma { get; set; }//
        public IList<DeteRoditeljView> Roditelji { get; set; }

        public DeteView() {

            Pisma = new List<PismoView>();
            Roditelji = new List<DeteRoditeljView>();
        }

        public DeteView(int iD, string ime, string prezime, string adresa, string grad, string drzava, DateTime datumRodjenja)
        {
            ID = iD;
            Ime = ime;
            Prezime = prezime;
            Adresa = adresa;
            Grad = grad;
            Drzava = drzava;
            DatumRodjenja = datumRodjenja;
            Pisma = new List<PismoView>();
            Roditelji = new List<DeteRoditeljView>();
        }
    }
}
