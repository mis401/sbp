using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class TimView
    {
        public  int ID { get; set; }
        public string Naziv { get; set; }
        public IList<VilenjakZaIzraduIgracakaView> Vilenjaci { get; set; }//
        public VilenjakZaIzraduIgracakaView Koordinator { get; set; }//


        public TimView()
        {
            Vilenjaci = new List<VilenjakZaIzraduIgracakaView>();
        }

        public TimView(Tim t)
        {
            ID = t.ID;
            Naziv = t.Naziv;
            Vilenjaci = new List<VilenjakZaIzraduIgracakaView>();
            Koordinator = new VilenjakZaIzraduIgracakaView(t.Koordinator);
        }
    }
}