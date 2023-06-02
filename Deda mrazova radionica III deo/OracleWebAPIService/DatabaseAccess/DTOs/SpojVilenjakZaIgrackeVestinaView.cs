using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class SpojVilenjakZaIgrackeVestinaView
    {
        public  int ID { get; set; }
        public  VilenjakZaIzraduIgracakaView VilenjakZaIzraduIgracaka { get; set; }
        public  MagicnaVestinaView MagicnaVestina { get; set; }

        public SpojVilenjakZaIgrackeVestinaView()
        {

        }

        public SpojVilenjakZaIgrackeVestinaView(int iD, VilenjakZaIzraduIgracakaView vilenjakZaIzraduIgracaka, MagicnaVestinaView magicnaVestina)
        {
            ID = iD;
            VilenjakZaIzraduIgracaka = vilenjakZaIzraduIgracaka;
            MagicnaVestina = magicnaVestina;
        }
    }
}