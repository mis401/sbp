using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class DeoRadionice
    {
        public virtual int ID { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string TipIgracke { get; set; }
        public virtual int BrojAngazovanihVilenjaka { get; set; }
        public virtual IList<Igracka> IgrackeIstogTipa { get; set; }
        public virtual IList<MagicnaVestina> ZahtevaVestinu { get; set; }
        //public virtual IList<Vilenjak> VilenjaciZaIzraduIgracaka { get; set; }

        public DeoRadionice() 
        { 
            IgrackeIstogTipa = new List<Igracka>();
        //    VilenjaciZaIzraduIgracaka = new List<Vilenjak>();
            ZahtevaVestinu = new List<MagicnaVestina>();
        }
    }
}
