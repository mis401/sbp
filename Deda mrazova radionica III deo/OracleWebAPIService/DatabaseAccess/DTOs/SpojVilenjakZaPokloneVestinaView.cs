using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class SpojVilenjakZaPokloneVestinaView
    {
        public int ID { get; set; }
        public VilenjakZaPokloneView VilenjakZaPoklone { get; set; }
        public MagicnaVestinaView MagicnaVestina { get; set; }

        public SpojVilenjakZaPokloneVestinaView() { }
        public SpojVilenjakZaPokloneVestinaView(int iD, VilenjakZaPokloneView vilenjakZaPoklone, MagicnaVestinaView magicnaVestina)
        {
            ID = iD;
            VilenjakZaPoklone = vilenjakZaPoklone;
            MagicnaVestina = magicnaVestina;
        }
    }
}