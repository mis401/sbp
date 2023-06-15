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

        public SpojVilenjakZaIrvaseVestinaView(SpojVilenjakZaIrvaseVestina s)
        {
            ID = s.ID;
            //VilenjakZaIrvase = new VilenjakZaIrvaseView(s.VilenjakZaIrvase);
            //MagicnaVestina = new MagicnaVestinaView(s.MagicnaVestina);
        }
    }
}