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
        public PesmaView(int iD, string naziv, string tekst, VilenjakZaIrvaseView vilenjakZaIrvase)
        {
            ID = iD;
            Naziv = naziv;
            Tekst = tekst;
            VilenjakZaIrvase = vilenjakZaIrvase;
        }
    }
}