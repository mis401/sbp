using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class TimView
    {
        public  int ID { get; set; }
        public string Naziv { get; set; }
        public IList<VilenjakZaIzraduIgracakaView> Vilejnaci { get; set; }//
        public VilenjakZaIzraduIgracakaView Koordinator { get; set; }//


        public TimView()
        {
            Vilejnaci = new List<VilenjakZaIzraduIgracakaView>();
        }

        public TimView(int iD, string naziv,VilenjakZaIzraduIgracakaView koordinator)
        {
            ID = iD;
            Naziv = naziv;
            Vilejnaci = new List<VilenjakZaIzraduIgracakaView>();
            Koordinator = koordinator;
        }
    }
}