using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class VilenjakZaPokloneView:VilenjakView
    {
        public  IList<PakovanjePoklonaView> PakovanjePoklona { get; set; }
        public  IList<SpojVilenjakZaPokloneVestinaView> VilenjakZaPokloneVestinaSpoj { get; set; }

        public VilenjakZaPokloneView() : base()
        {
            PakovanjePoklona = new List<PakovanjePoklonaView>();
            VilenjakZaPokloneVestinaSpoj = new List<SpojVilenjakZaPokloneVestinaView>();
        }

        public VilenjakZaPokloneView(int iD, string jedinstvenoIme, string zemljaPorekla, DateTime datumZaposlenja) : base(iD, jedinstvenoIme, zemljaPorekla, datumZaposlenja)
        {
            PakovanjePoklona = new List<PakovanjePoklonaView>();
            VilenjakZaPokloneVestinaSpoj = new List<SpojVilenjakZaPokloneVestinaView>();
        }
    }
}