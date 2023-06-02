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

        public PakovanjePoklonaView(int iD, VilenjakZaPokloneView vilenjakZaPoklone, PoklonView poklon)
        {
            ID = iD;
            VilenjakZaPoklone = vilenjakZaPoklone;
            Poklon = poklon;
        }
    }
}