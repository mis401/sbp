using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class ListaZelja
    {
        public virtual int ID { get; set; }
        public virtual IList<Igracka> ZeljeneIgracke { get; set; }
        public virtual Pismo PripadaPismu { get; set; }
        
        public virtual Poklon Poklon { get; set; }
        public ListaZelja() 
        { 
            ZeljeneIgracke = new List<Igracka>();
        }
    }
}
