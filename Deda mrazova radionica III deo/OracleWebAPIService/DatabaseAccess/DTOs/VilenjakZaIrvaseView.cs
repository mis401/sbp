using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class VilenjakZaIrvaseView :VilenjakView
    {
        public IrvasView Irvas { get; set; }//
        public IList<PesmaView> Pesme { get; set; }//

        public IList<SpojVilenjakZaIrvaseVestinaView> VilenjakZaIrvaseVestinaSpoj { get; set; }
        public VilenjakZaIrvaseView() : base()
        {
            VilenjakZaIrvaseVestinaSpoj = new List<SpojVilenjakZaIrvaseVestinaView>();
            Pesme = new List<PesmaView>();
        }
        public VilenjakZaIrvaseView(VilenjakZaIrvase v) : base(v)
        {
            //Irvas = new IrvasView(v.Irvas);
            VilenjakZaIrvaseVestinaSpoj = new List<SpojVilenjakZaIrvaseVestinaView>();
            Pesme = new List<PesmaView>();
        }
    }
}