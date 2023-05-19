using System;
using System.Collections;
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
        public virtual Tim PripadaTimu { get; set; }//za obe veze
        public virtual int FlagSef { get; set; }
        public virtual DeoRadionice DeoRadionice { get; set;}//je sef i gde radi
        public virtual DateTime DatumPostavljanja { get; set; }
        public virtual VilenjakZaIzraduIgracaka ImaMentora{ get; set; }// ova dva su za 1:n unarnu
        public virtual IList<VilenjakZaIzraduIgracaka> JeMentor { get; set; }//1:n unarna
        public virtual int DuzinaObuke { get; set; }
        public virtual int Ocena { get; set; }
        public virtual IList<Igracka> Igracke { get; set; }//

        public virtual IList<SpojVilenjakZaIgrackeVestina> VilenjakZaIgrackeVestinaSpoj { get; set; }

        public VilenjakZaIzraduIgracaka() : base()
        {
            Igracke = new List<Igracka>();
            JeMentor = new List<VilenjakZaIzraduIgracaka>();
            VilenjakZaIgrackeVestinaSpoj = new List<SpojVilenjakZaIgrackeVestina>();
        }
    }
}
