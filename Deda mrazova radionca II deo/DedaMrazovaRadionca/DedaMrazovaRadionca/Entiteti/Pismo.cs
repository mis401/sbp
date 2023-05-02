using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionca.Entiteti
{
    public class Pismo
    {
        public Pismo() { }
        public virtual int ID { get; set; }
        public virtual string Tekst { get; set; }
        public virtual float Indeks_dobrote { get; set; }

    }
}
