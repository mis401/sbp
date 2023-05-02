using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionca.Entiteti
{
    public class Vilenjak
    {
        public Vilenjak() { }
        public virtual int ID { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Zemlja_porekla { get; set; }
        public virtual DateTime Datum_zaposljavanja { get; set; }
        public virtual string Vrsta_vilenjaka { get; set; }

       // public virtual int Duzina_rada { get; set; }





    }
}
