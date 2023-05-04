using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class Pismo
    {
        public virtual int ID { get; set; }
        public virtual float IndeksDobrote { get; set; }
        public virtual string Tekst { get; set; }
        public virtual DateTime DatumSlanja { get; set; }
        public virtual DateTime DatumPrijema { get; set; }
        public virtual Dete PripadaDetetu { get; set; }
        
        public Pismo() { }

    }
}
