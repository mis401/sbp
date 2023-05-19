using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class Vilenjak
    {
        public virtual int ID { get; set; }
        public virtual string JedinstvenoIme { get; set; }
        public virtual string ZemljaPorekla { get; set; }
        public virtual DateTime DatumZaposlenja { get; set; }
        public Vilenjak()
        {
         //   MagicneVestine = new List<MagicnaVestina>();
        }
    }
}
