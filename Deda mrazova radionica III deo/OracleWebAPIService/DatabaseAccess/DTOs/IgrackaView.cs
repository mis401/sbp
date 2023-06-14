using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class IgrackaView
    {
        public  int ID { get; set; }
        public  int RedniBroj { get; set; }
        public  string Tip { get; set; }
        public string Opis { get; set; }
        public  PoklonView? PripadaPoklonu { get; set; }
        public DeoRadioniceView? IzradjenaUDeluRadionice { get; set; }
        public ListaZeljaView? PripadaListiZelja { get; set; }
        public VilenjakZaIzraduIgracakaView? Vilenjak { get; set; }

        public IgrackaView() { }
        public IgrackaView(Igracka i)
        {
            ID = i.ID;
            RedniBroj = i.RedniBroj;
            Tip = i.Tip;
            Opis = i.Opis;
            //PripadaPoklonu = new PoklonView(i.PripadaPoklonu);
            //PripadaListiZelja = new ListaZeljaView(i.PripadaListiZelja);
            //IzradjenaUDeluRadionice = new DeoRadioniceView(i.IzradjenaUDeluRadionice);
            //Vilenjak = new VilenjakZaIzraduIgracakaView(i.Vilenjak);
        }
    }
}