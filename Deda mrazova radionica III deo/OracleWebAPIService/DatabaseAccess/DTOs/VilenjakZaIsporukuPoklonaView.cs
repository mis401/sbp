using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class VilenjakZaIsporukuPoklonaView : VilenjakView
    {
        public  TovarView Tovar { get; set; }//
        public IList<SpojVilenjakZaIsporukuVestinaView> VilenjakZaIsporukuVestinaSpoj { get; set; }

        public VilenjakZaIsporukuPoklonaView() : base()
        {
            VilenjakZaIsporukuVestinaSpoj = new List<SpojVilenjakZaIsporukuVestinaView>();
        }

        public VilenjakZaIsporukuPoklonaView(int iD, string jedinstvenoIme, string zemljaPorekla, DateTime datumZaposlenja, TovarView tovar) : base(iD, jedinstvenoIme, zemljaPorekla, datumZaposlenja)
        {
            Tovar = tovar;
            VilenjakZaIsporukuVestinaSpoj = new List<SpojVilenjakZaIsporukuVestinaView>();
        }
    }
}