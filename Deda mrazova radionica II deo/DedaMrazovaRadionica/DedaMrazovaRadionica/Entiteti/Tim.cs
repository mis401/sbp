using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class Tim
    {
        public virtual int ID { get; set; }
        public virtual string Naziv { get; set; }
        public virtual IList<Vilenjak> VilejnaciZaIzraduIgracaka { get; set; }

        public Tim() 
        {
            VilejnaciZaIzraduIgracaka = new List<Vilenjak>();
        }
    }
}
