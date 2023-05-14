using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class Igracka
    {
        public virtual int ID { get; set; }
        public virtual int RedniBroj { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Opis { get; set; }
        public virtual Poklon PripadaPoklonu { get; set; }
        public virtual DeoRadionice IzradjenaUDeluRadionice { get; set; }
        public virtual ListaZelja PripadaListiZelja { get; set; }
        //public virtual Vilenjak VilenjakZaIzraduIgracaka {  get; set; }
        public Igracka() { }

    }
}
