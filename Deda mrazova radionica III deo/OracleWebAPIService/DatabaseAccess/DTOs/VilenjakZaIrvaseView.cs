using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class VilenjakZaIrvaseView :VilenjakView
    {
        public Irvas Irvas { get; set; }//
        public IList<PesmaView> Pesme { get; set; }//

        public IList<SpojVilenjakZaIrvaseVestinaView> VilenjakZaIrvaseVestinaSpoj { get; set; }
        public VilenjakZaIrvaseView() : base()
        {
            VilenjakZaIrvaseVestinaSpoj = new List<SpojVilenjakZaIrvaseVestinaView>();
            Pesme = new List<PesmaView>();
        }
        public VilenjakZaIrvaseView(VilenjakZaIrvase v) : base(v)
        {
            Irvas = v.Irvas;
            VilenjakZaIrvaseVestinaSpoj = new List<SpojVilenjakZaIrvaseVestinaView>();
            Pesme = new List<PesmaView>();
        }
    }
}