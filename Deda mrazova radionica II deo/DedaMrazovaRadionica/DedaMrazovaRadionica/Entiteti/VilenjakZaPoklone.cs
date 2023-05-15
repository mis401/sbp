using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class VilenjakZaPoklone : Vilenjak
    {
        public virtual IList<Poklon> Pokloni { get; set; }
        public VilenjakZaPoklone() : base()
        {
            Pokloni = new List<Poklon>();
        }
    }
}
