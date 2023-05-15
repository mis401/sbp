using Remotion.Linq.Clauses.ResultOperators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class PakovanjePoklona
    {
        public virtual int ID { get; set; }
        public virtual VilenjakZaPoklone VilenjakZaPoklone { get; set; }
        public virtual Poklon Poklon { get; set; }
    }
}
