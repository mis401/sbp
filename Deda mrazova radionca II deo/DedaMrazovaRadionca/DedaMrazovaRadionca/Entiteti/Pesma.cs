using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionca.Entiteti
{
    public class Pesma
    {
        public Pesma() { }
        public virtual int ID { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Tekst { get; set; }
    }
}
