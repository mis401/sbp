using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class TovarView
    {
        public  int ID { get; set; }
        public string Grad { get; set; }
        public IList<PoklonView> Pokloni { get; set; }//
        public IList<VilenjakZaIsporukuPoklonaView> Vilenjaci { get; set; }//

        public IList<IrvasIsporucujeTovarView> IrvasIsporucujeTovar { get; set; }
        public TovarView()
        {
            Pokloni = new List<PoklonView>();
            IrvasIsporucujeTovar = new List<IrvasIsporucujeTovarView>();
            Vilenjaci = new List<VilenjakZaIsporukuPoklonaView>();
        }
        public TovarView(int iD, string grad)
        {
            ID = iD;
            Grad = grad;
            Pokloni = new List<PoklonView>();
            IrvasIsporucujeTovar = new List<IrvasIsporucujeTovarView>();
            Vilenjaci = new List<VilenjakZaIsporukuPoklonaView>();
        }
    }
}