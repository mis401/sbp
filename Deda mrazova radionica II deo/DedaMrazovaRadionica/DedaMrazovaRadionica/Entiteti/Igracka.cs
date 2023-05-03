using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class Igracka
    {
        public virtual int ID { get; set; }
        public virtual int Redni_broj { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Opis { get; set; }
        public Igracka() { }

    }
}
