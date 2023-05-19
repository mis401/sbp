using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class VilenjakZaPoklone : Vilenjak
    {
        public virtual IList<PakovanjePoklona> PakovanjePoklona { get; set; }
        public virtual IList<SpojVilenjakZaPokloneVestina> VilenjakZaPokloneVestinaSpoj { get; set; }

        public VilenjakZaPoklone() : base()
        {
            PakovanjePoklona = new List<PakovanjePoklona>();
            VilenjakZaPokloneVestinaSpoj = new List<SpojVilenjakZaPokloneVestina>();
        }
    }
}
