using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class PakovanjePoklonaView
    {
        public int ID { get; set; }
        public VilenjakZaPokloneView VilenjakZaPoklone { get; set; }
        public PoklonView Poklon { get; set; }

        public PakovanjePoklonaView()
        {

        }

        public PakovanjePoklonaView(PakovanjePoklona p)
        {
            ID = p.ID;
            VilenjakZaPoklone = new VilenjakZaPokloneView(p.VilenjakZaPoklone);
            Poklon = new PoklonView(p.Poklon);
        }
    }
}