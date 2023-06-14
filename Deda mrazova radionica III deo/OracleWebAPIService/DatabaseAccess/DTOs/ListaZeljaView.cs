using DatabaseAccess.Entiteti;
using System;
using System.Collections.Generic;
using System.IO.Compression;
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
        public ListaZeljaView(ListaZelja lz)
        {
            ID = lz.ID;
            PripadaPismu = new PismoView(lz.PripadaPismu);
            ZeljeneIgracke = new List<IgrackaView>();
            Poklon = new PoklonView(lz.Poklon);    
        }
    }
}
