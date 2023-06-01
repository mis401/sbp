using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class SpojVilenjakZaIgrackeVestina
    {
        public virtual int ID { get; set; }
        public virtual VilenjakZaIzraduIgracaka VilenjakZaIzraduIgracaka { get; set; }
        public virtual MagicnaVestina MagicnaVestina { get; set; }
    }
}
