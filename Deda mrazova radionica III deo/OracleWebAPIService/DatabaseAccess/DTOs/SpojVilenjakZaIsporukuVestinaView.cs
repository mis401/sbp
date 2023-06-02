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

        public SpojVilenjakZaIsporukuVestinaView(int iD, VilenjakZaIsporukuPoklonaView vilenjakZaIsporukuPoklona, MagicnaVestinaView magicnaVestina)
        {
            ID = iD;
            VilenjakZaIsporukuPoklona = vilenjakZaIsporukuPoklona;
            MagicnaVestina = magicnaVestina;
        }
    }
}