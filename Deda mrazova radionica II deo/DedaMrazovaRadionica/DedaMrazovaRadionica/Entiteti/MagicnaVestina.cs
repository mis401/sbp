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
        public virtual DeoRadionice PotrebnaDeluRadionice {  get; set; }

        public virtual IList<VilenjakZaIrvase> VilenjaciZaIrvase { get; set; }
        public virtual IList<VilenjakZaIsporukuPoklona> VilenjaciZaIsporukuPoklona { get; set; }
        public virtual IList<VilenjakZaIzraduIgracaka> VilenjaciZaIzraduIgracaka { get; set; }
        public virtual IList<VilenjakZaPoklone> VilenjaciZaPoklone { get; set; }
        public MagicnaVestina() 
        {
            VilenjaciZaIrvase = new List<VilenjakZaIrvase>();
            VilenjaciZaIsporukuPoklona = new List<VilenjakZaIsporukuPoklona>();
            VilenjaciZaIzraduIgracaka = new List<VilenjakZaIzraduIgracaka>();
            VilenjaciZaPoklone = new List<VilenjakZaPoklone>();

        }

    }
}
