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

        public SpojVilenjakZaIgrackeVestinaView(SpojVilenjakZaIgrackeVestina s)
        {
            ID = s.ID;
            VilenjakZaIzraduIgracaka = new VilenjakZaIzraduIgracakaView(s.VilenjakZaIzraduIgracaka);
            MagicnaVestina = new MagicnaVestinaView(s.MagicnaVestina);
        }
    }
}