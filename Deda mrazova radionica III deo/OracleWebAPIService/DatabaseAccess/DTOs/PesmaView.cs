using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class PesmaView
    {
        public  int ID { get; set; }
        public string Naziv { get; set; }
        public  string Tekst { get; set; }
        public VilenjakZaIrvaseView VilenjakZaIrvase { get; set; }//
        public PesmaView()
        {

        }
        public PesmaView(Pesma p)
        {
            ID = p.ID;
            Naziv = p.Naziv;
            Tekst = p.Tekst;
            VilenjakZaIrvase = new VilenjakZaIrvaseView(p.VilenjakZaIrvase);
        }
    }
}