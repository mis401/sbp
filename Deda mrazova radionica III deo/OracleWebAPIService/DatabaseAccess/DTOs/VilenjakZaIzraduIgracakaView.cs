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
        public VilenjakZaIzraduIgracakaView? ImaMentora { get; set; }// ova dva su za 1:n unarnu
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

        public VilenjakZaIzraduIgracakaView(VilenjakZaIzraduIgracaka v) : base(v)
        {
            TipMaterijala = v.TipMaterijala;
            FlagKoordinator = v.FlagKoordinator;
            PripadaTimu = new TimView(v.PripadaTimu);
            FlagSef = v.FlagSef;
            DeoRadionice = new DeoRadioniceView(v.DeoRadionice);
            DatumPostavljanja = v.DatumPostavljanja;
           // ImaMentora = new VilenjakZaIzraduIgracakaView(v.ImaMentora);
            DuzinaObuke = v.DuzinaObuke;
            Ocena = v.Ocena;
            Igracke = new List<IgrackaView>();
            JeMentor = new List<VilenjakZaIzraduIgracakaView>();
            VilenjakZaIgrackeVestinaSpoj = new List<SpojVilenjakZaIgrackeVestinaView>();
        }
    }
}