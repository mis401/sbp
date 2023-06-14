using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class DeteRoditeljView
    {
        public  int ID { get; set; }
        public string Roditelj { get; set; }
        public DeteView Dete { get; set; }

        public DeteRoditeljView() { }
        public DeteRoditeljView(DeteRoditelj d)
        {
            ID = d.ID; Roditelj = d.Roditelj; Dete = new DeteView(d.Dete);
        }
    }
}