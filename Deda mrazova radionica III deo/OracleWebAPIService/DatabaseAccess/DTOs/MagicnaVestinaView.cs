using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class MagicnaVestinaView
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public DeoRadioniceView PotrebnaDeluRadionice { get; set; }//
        public IList<SpojVilenjakZaIrvaseVestinaView> VilenjakZaIrvaseVestinaSpoj { get; set; }
        public IList<SpojVilenjakZaIsporukuVestinaView> VilenjakZaIsporukuVestinaSpoj { get; set; }
        public IList<SpojVilenjakZaIgrackeVestinaView> VilenjakZaIgrackeVestinaSpoj { get; set; }

        public IList<SpojVilenjakZaPokloneVestinaView> VilenjakZaPokloneVestinaSpoj { get; set; }

        public MagicnaVestinaView()
        {
            VilenjakZaIrvaseVestinaSpoj = new List<SpojVilenjakZaIrvaseVestinaView>();
            VilenjakZaIsporukuVestinaSpoj = new List<SpojVilenjakZaIsporukuVestinaView>();
            VilenjakZaIgrackeVestinaSpoj = new List<SpojVilenjakZaIgrackeVestinaView>();
            VilenjakZaPokloneVestinaSpoj = new List<SpojVilenjakZaPokloneVestinaView>();


        }

        public MagicnaVestinaView(int iD, string naziv, DeoRadioniceView potrebnaDeluRadionice)
        {
            ID = iD;
            Naziv = naziv;
            PotrebnaDeluRadionice = potrebnaDeluRadionice;
            VilenjakZaIrvaseVestinaSpoj = new List<SpojVilenjakZaIrvaseVestinaView>();
            VilenjakZaIsporukuVestinaSpoj = new List<SpojVilenjakZaIsporukuVestinaView>();
            VilenjakZaIgrackeVestinaSpoj = new List<SpojVilenjakZaIgrackeVestinaView>();
            VilenjakZaPokloneVestinaSpoj = new List<SpojVilenjakZaPokloneVestinaView>();
        }
    }
}