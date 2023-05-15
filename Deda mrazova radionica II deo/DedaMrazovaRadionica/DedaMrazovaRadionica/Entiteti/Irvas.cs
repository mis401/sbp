using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class Irvas
    {
        public virtual int ID { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Nadimak { get; set; }
        public virtual char Pol { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual IList<VilenjakZaIrvase> Vilenjaci { get; set; }

        public virtual IList<Tovar> Tovari { get; set; }
        public virtual int Starost { get; set; }
        public Irvas()
        {
            Tovari = new List<Tovar>();
            Vilenjaci= new List<VilenjakZaIrvase>();
        }
    }
}
