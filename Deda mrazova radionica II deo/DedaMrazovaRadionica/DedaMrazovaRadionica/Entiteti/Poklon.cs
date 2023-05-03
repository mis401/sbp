using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class Poklon
    {
        public virtual int ID { get; set; }
        public virtual string Boja { get; set; }
        public virtual string Posveta { get; set; }

        public Poklon() { }
    }
}
