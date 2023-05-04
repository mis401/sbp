using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class Dete
    {
        public virtual int ID { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Grad { get; set; }
        public virtual string Drzava { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual IList<Pismo> Pisma { get; set; }

        public Dete() 
        {
            Pisma = new List<Pismo>();
        }
    }
}
