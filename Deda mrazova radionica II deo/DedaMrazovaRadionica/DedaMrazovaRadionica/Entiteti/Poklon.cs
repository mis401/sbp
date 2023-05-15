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
       // public virtual IList<Igracka> IgrackeZaPoklon { get; set; }
        public virtual Tovar PripadaTovaru { get; set; }
        public virtual ListaZelja ZaListuZelja { get; set; }

        public virtual IList<VilenjakZaPoklone> Vilenjaci { get; set; }

        public Poklon() 
        {
           // IgrackeZaPoklon = new List<Igracka>();
           Vilenjaci = new List <VilenjakZaPoklone>();
        }
    }
}
