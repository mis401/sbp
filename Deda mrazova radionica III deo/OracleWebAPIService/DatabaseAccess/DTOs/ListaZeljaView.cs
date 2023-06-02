using DatabaseAccess.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class ListaZeljaView
    {
        public   int ID { get; set; }
        public IList<IgrackaView> ZeljeneIgracke { get; set; }
        public PismoView PripadaPismu { get; set; }//

        public  PoklonView Poklon { get; set; }//
        public ListaZeljaView()
        {
            ZeljeneIgracke = new List<IgrackaView>();
        }
        public ListaZeljaView(int iD, PismoView pripadaPismu, PoklonView poklon)
        {
            ID = iD;
            PripadaPismu = pripadaPismu;
            ZeljeneIgracke = new List<IgrackaView>();
            Poklon = poklon;    
        }
    }
}
