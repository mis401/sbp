using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class VilenjakZaIrvase : Vilenjak
    {
        public virtual Irvas Irvas { get; set; }//
        public virtual IList<Pesma> Pesme { get; set; }//

        public virtual IList<SpojVilenjakZaIrvaseVestina> VilenjakZaIrvaseVestinaSpoj { get; set; }
        public VilenjakZaIrvase():base()
        {
            VilenjakZaIrvaseVestinaSpoj = new List<SpojVilenjakZaIrvaseVestina>();
            Pesme = new List<Pesma>();
        }
    }
}
