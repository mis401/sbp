using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionca.Entiteti
{
    public class Igracka
    {
        public Igracka() { }
        public virtual int ID { get; set; }
        public virtual int Redni_broj { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Opis { get; set; }
    }
}
