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
        public ListaZeljaView ZaListuZelja { get; set; }

        public IList<PakovanjePoklonaView> PakovanjePoklona { get; set; }

        public PoklonView() {

            IgrackeZaPoklon = new List<IgrackaView>();
            PakovanjePoklona = new List<PakovanjePoklonaView>();
        }
        public PoklonView(int iD, string boja, string posveta, TovarView pripadaTovaru, ListaZeljaView zaListuZelja)
        {
            ID = iD;
            Boja = boja;
            Posveta = posveta;
            PripadaTovaru = pripadaTovaru;
            ZaListuZelja = zaListuZelja;
            IgrackeZaPoklon = new List<IgrackaView>();
            PakovanjePoklona = new List<PakovanjePoklonaView>();
        }
    }
}
