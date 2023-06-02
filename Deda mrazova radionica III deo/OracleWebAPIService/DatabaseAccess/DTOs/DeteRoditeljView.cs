using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class DeteRoditeljView
    {
        public  int ID { get; set; }
        public string Roditelj { get; set; }
        public DeteView Dete { get; set; }

        DeteRoditeljView() { }
        DeteRoditeljView(int iD, string roditelj, DeteView dete)
        {
            ID = iD;
            Roditelj = roditelj;
            Dete = dete;
        }
    }
}