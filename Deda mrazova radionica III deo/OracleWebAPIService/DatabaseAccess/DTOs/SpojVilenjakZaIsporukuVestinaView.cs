using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class SpojVilenjakZaIsporukuVestinaView
    {
        public int ID { get; set; }
        public VilenjakZaIsporukuPoklonaView VilenjakZaIsporukuPoklona { get; set; }
        public MagicnaVestinaView MagicnaVestina { get; set; }

        public SpojVilenjakZaIsporukuVestinaView()
        {

        }

        public SpojVilenjakZaIsporukuVestinaView(SpojVilenjakZaIsporukuVestina s)
        {
            ID = s.ID;
            VilenjakZaIsporukuPoklona = new VilenjakZaIsporukuPoklonaView(s.VilenjakZaIsporukuPoklona);
            MagicnaVestina = new MagicnaVestinaView(s.MagicnaVestina);
        }
    }
}