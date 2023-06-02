using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class VilenjakZaIzraduIgracakaView : VilenjakView
    {
        public  string TipMaterijala { get; set; }
        public  int FlagKoordinator { get; set; }
        public  TimView PripadaTimu { get; set; }//za obe veze
        public int FlagSef { get; set; }
        public DeoRadioniceView DeoRadionice { get; set; }//je sef i gde radi
        public DateTime DatumPostavljanja { get; set; }
        public VilenjakZaIzraduIgracakaView ImaMentora { get; set; }// ova dva su za 1:n unarnu
        public IList<VilenjakZaIzraduIgracakaView> JeMentor { get; set; }//1:n unarna
        public int DuzinaObuke { get; set; }
        public int Ocena { get; set; }
        public IList<IgrackaView> Igracke { get; set; }//

        public IList<SpojVilenjakZaIgrackeVestinaView> VilenjakZaIgrackeVestinaSpoj { get; set; }

        public VilenjakZaIzraduIgracakaView() : base()
        {
            Igracke = new List<IgrackaView>();
            JeMentor = new List<VilenjakZaIzraduIgracakaView>();
            VilenjakZaIgrackeVestinaSpoj = new List<SpojVilenjakZaIgrackeVestinaView>();
        }

        public VilenjakZaIzraduIgracakaView(int iD, string jedinstvenoIme, string zemljaPorekla, DateTime datumZaposlenja, string tipMaterijala, int flagKoordinator, TimView pripadaTimu, int flagSef, DeoRadioniceView deoRadionice, DateTime datumPostavljanja, VilenjakZaIzraduIgracakaView imaMentora, int duzinaObuke, int ocena) : base(iD, jedinstvenoIme, zemljaPorekla, datumZaposlenja)
        {
            TipMaterijala = tipMaterijala;
            FlagKoordinator = flagKoordinator;
            PripadaTimu = pripadaTimu;
            FlagSef = flagSef;
            DeoRadionice = deoRadionice;
            DatumPostavljanja = datumPostavljanja;
            ImaMentora = imaMentora;
            DuzinaObuke = duzinaObuke;
            Ocena = ocena;
            Igracke = new List<IgrackaView>();
            JeMentor = new List<VilenjakZaIzraduIgracakaView>();
            VilenjakZaIgrackeVestinaSpoj = new List<SpojVilenjakZaIgrackeVestinaView>();
        }
    }
}