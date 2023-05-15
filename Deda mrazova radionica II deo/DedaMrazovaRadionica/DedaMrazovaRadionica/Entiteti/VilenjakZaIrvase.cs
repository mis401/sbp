using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class VilenjakZaIrvase : Vilenjak
    {
        public virtual Irvas Irvas { get; set; }

        public VilenjakZaIrvase():base()
        {

        }
    }
}
