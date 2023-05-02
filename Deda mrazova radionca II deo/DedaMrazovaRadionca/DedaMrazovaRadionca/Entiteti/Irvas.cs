using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionca.Entiteti
{
    public class Irvas
    {
        public Irvas() { }
        public virtual int ID { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Nadimak { get; set; }
        public virtual char Pol { get; set; }
        public virtual DateTime Datum_rodjenja { get; set; }
        public virtual int Starost { get; set; }


    }
}
