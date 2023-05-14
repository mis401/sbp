using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class Pesma
    {
        public virtual int ID { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Tekst { get; set; }
        //public virtual Vilenjak PripadaVelenjakuZaIrvase { get; set; }
        public Pesma() { }
    }
}
