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

        public VilenjakZaIsporukuPoklonaView(VilenjakZaIsporukuPoklona v) : base(v)
        {
            Tovar = new TovarView(v.Tovar);
            VilenjakZaIsporukuVestinaSpoj = new List<SpojVilenjakZaIsporukuVestinaView>();
        }
    }
}