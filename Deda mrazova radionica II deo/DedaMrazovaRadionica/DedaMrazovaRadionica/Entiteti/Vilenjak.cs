using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DedaMrazovaRadionica.Entiteti
{
    public class Vilenjak
    {
        public virtual int ID { get; set; }
        public virtual string Ime { get; set; }
        public virtual string ZemljaPorekla { get; set; }
        public virtual DateTime DatumZaposlenja { get; set; }
        public virtual string VrstaVilenjaka { get; set; }
        public virtual Irvas IrvasZaUmirivanje { get; set; }
        public virtual Tovar PripremaTovar { get; set; }
        public virtual string TipMaterijala { get; set; }
        public virtual int FlagKoordinator { get; set; }
        public virtual Tim PripadaTimu { get; set; }
        public virtual int FlagSef { get; set; }
        public virtual DateTime DatumPostavljanja { get; set; }
        public virtual int Ocena { get; set; }
        public virtual int DuzinaObuke { get; set; }
        public virtual DeoRadionice PripadaDeluRadionice { get; set; }
        public virtual Vilenjak Mentor { get; set; }
        public virtual IList<Igracka> IzradjeneIgracke { get; set; }
        public virtual IList<Pesma> Pesme { get; set; }


        public Vilenjak() 
        {
            IzradjeneIgracke = new List<Igracka>();
            Pesme=new List<Pesma>();
        }
    }
}
