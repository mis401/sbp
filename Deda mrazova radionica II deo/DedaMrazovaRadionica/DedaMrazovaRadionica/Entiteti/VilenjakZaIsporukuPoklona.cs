using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class VilenjakZaIsporukuPoklona : Vilenjak
    {
        public virtual Tovar Tovar { get; set; }
        public VilenjakZaIsporukuPoklona() : base()
        {

        }
    }
}
