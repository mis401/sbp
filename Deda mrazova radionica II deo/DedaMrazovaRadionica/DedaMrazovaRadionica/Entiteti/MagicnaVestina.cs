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

        public MagicnaVestina() 
        {
       
        }

    }
}
