using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class SpojVilenjakZaPokloneVestinaView
    {
        public int ID { get; set; }
        public VilenjakZaPokloneView VilenjakZaPoklone { get; set; }
        public MagicnaVestinaView MagicnaVestina { get; set; }

        public SpojVilenjakZaPokloneVestinaView() { }
        public SpojVilenjakZaPokloneVestinaView(SpojVilenjakZaPokloneVestina svpv)
        {
            ID = svpv.ID;
            //VilenjakZaPoklone = new VilenjakZaPokloneView(svpv.VilenjakZaPoklone);
            //MagicnaVestina = new MagicnaVestinaView(svpv.MagicnaVestina);
        }
    }
}