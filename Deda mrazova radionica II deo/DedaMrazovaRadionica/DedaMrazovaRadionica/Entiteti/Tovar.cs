using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class Tovar
    {
        public virtual int ID { get; set; }
        public virtual string Grad { get; set; }
        public Tovar() { }
    }
}
