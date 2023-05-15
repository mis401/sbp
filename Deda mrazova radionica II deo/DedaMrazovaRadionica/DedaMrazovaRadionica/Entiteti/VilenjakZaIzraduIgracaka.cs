using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class VilenjakZaIzraduIgracaka : Vilenjak
    {
        public virtual string TipMaterijala { get; set; }
        public virtual int FlagKoordinator { get; set; }
        public virtual Tim Tim { get; set; }
        public virtual int FlagSef { get; set; }
        public virtual DeoRadionice DeoRadionice { get; set; }
        public virtual DateTime DatumPostavljanja { get; set; }
        public virtual VilenjakZaIzraduIgracaka Mentor { get; set; }
        public virtual int DuzinaObuke { get; set; }
        public virtual int Ocena { get; set; }

        public virtual IList<Igracka> Igracke { get; set; }

        public VilenjakZaIzraduIgracaka() : base()
        {
            Igracke = new List<Igracka>();
        }
    }
}
