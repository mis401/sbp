using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    public class Tovar
    {
        public virtual int ID { get; set; }
        public virtual string Grad { get; set; }
        public virtual IList<Poklon> Pokloni { get; set; }
        public virtual IList<VilenjakZaIsporukuPoklona> Vilenjaci { get; set; }
       
        public virtual IList<IrvasIsporucujeTovar> IrvasIsporucujeTovar { get; set; }
        public Tovar() 
        {
            Pokloni = new List<Poklon>();
            IrvasIsporucujeTovar = new List<IrvasIsporucujeTovar>();
            Vilenjaci = new List<VilenjakZaIsporukuPoklona>();
        }
    }
}
