using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class IgrackaView
    {
        public  int ID { get; set; }
        public  int RedniBroj { get; set; }
        public  string Tip { get; set; }
        public string Opis { get; set; }
        public  PoklonView PripadaPoklonu { get; set; }
        public DeoRadioniceView IzradjenaUDeluRadionice { get; set; }
        public ListaZeljaView PripadaListiZelja { get; set; }
        public VilenjakZaIzraduIgracakaView Vilenjak { get; set; }

        public IgrackaView() { }
        public IgrackaView(int iD, int redniBroj, string tip, string opis, PoklonView pripadaPoklonu, DeoRadioniceView izradjenaUDeluRadionice, ListaZeljaView pripadaListiZelja, VilenjakZaIzraduIgracakaView vilenjak)
        {
            ID = iD;
            RedniBroj = redniBroj;
            Tip = tip;
            Opis = opis;
            PripadaPoklonu = pripadaPoklonu;
            IzradjenaUDeluRadionice = izradjenaUDeluRadionice;
            PripadaListiZelja = pripadaListiZelja;
            Vilenjak = vilenjak;
        }
    }
}