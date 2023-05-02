using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionca.Entiteti
{
    public class DeoRadionice
    {
        public DeoRadionice() { }
        public virtual int ID { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Tip_igracke { get; set; }
        //public virtual int Broj_angazovanih_vilenjaka { get; set; }

    }
}
