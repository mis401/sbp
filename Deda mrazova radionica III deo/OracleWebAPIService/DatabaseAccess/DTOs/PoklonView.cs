using DatabaseAccess.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class PoklonView
    {
        public  int ID { get; set; }
        public  string Boja { get; set; }
        public string Posveta { get; set; }
        public  IList<IgrackaView> IgrackeZaPoklon { get; set; }
        public TovarView PripadaTovaru { get; set; }
        public ListaZeljaView? ZaListuZelja { get; set; }

        public IList<PakovanjePoklonaView> PakovanjePoklona { get; set; }

        public PoklonView() {

            IgrackeZaPoklon = new List<IgrackaView>();
            PakovanjePoklona = new List<PakovanjePoklonaView>();
        }
        public PoklonView(Poklon p)
        {
            ID = p.ID;
            Boja = p.Boja;
            Posveta = p.Posveta;
            PripadaTovaru = new TovarView(p.PripadaTovaru);
            //ZaListuZelja = new ListaZeljaView(p.ZaListuZelja);
            IgrackeZaPoklon = new List<IgrackaView>();
            PakovanjePoklona = new List<PakovanjePoklonaView>();
        }
    }
}
