using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class MagicnaVestina
    {
        public virtual int ID { get; set; }
        public virtual string Naziv { get; set; }
        public virtual DeoRadionice PotrebnaDeluRadionice { get; set; }//
        public virtual IList<SpojVilenjakZaIrvaseVestina> VilenjakZaIrvaseVestinaSpoj { get; set; }
        public virtual IList<SpojVilenjakZaIsporukuVestina> VilenjakZaIsporukuVestinaSpoj { get; set; }
        public virtual IList<SpojVilenjakZaIgrackeVestina> VilenjakZaIgrackeVestinaSpoj { get; set; }

        public virtual IList<SpojVilenjakZaPokloneVestina> VilenjakZaPokloneVestinaSpoj { get; set; }
        public MagicnaVestina()
        {
            VilenjakZaIrvaseVestinaSpoj = new List<SpojVilenjakZaIrvaseVestina>();
            VilenjakZaIsporukuVestinaSpoj = new List<SpojVilenjakZaIsporukuVestina>();
            VilenjakZaIgrackeVestinaSpoj = new List<SpojVilenjakZaIgrackeVestina>();
            VilenjakZaPokloneVestinaSpoj = new List<SpojVilenjakZaPokloneVestina>();


        }

    }
}
