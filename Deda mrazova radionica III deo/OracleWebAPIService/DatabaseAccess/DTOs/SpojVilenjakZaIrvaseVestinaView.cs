using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class SpojVilenjakZaIrvaseVestinaView
    {
        public int ID { get; set; }
        public VilenjakZaIrvaseView VilenjakZaIrvase { get; set; }
        public MagicnaVestinaView MagicnaVestina { get; set; }

        public SpojVilenjakZaIrvaseVestinaView()
        {

        }

        public SpojVilenjakZaIrvaseVestinaView(int iD, VilenjakZaIrvaseView vilenjakZaIrvase, MagicnaVestinaView magicnaVestina)
        {
            ID = iD;
            VilenjakZaIrvase = vilenjakZaIrvase;
            MagicnaVestina = magicnaVestina;
        }
    }
}