using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class IrvasView
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Nadimak { get; set; }
        public char Pol { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public IList<VilenjakZaIrvaseView> Vilenjaci { get; set; }//

        public IList<IrvasIsporucujeTovarView> IrvasIsporucujeTovar { get; set; }
        public int Starost { get; set; }
        public IrvasView()
        {

            Vilenjaci = new List<VilenjakZaIrvaseView>();
            IrvasIsporucujeTovar = new List<IrvasIsporucujeTovarView>();
        }

        public IrvasView(int iD, string ime, string nadimak, char pol, DateTime datumRodjenja,int starost)
        {
            ID = iD;
            Ime = ime;
            Nadimak = nadimak;
            Pol = pol;
            DatumRodjenja = datumRodjenja;
            Vilenjaci = new List<VilenjakZaIrvaseView>();
            IrvasIsporucujeTovar = new List<IrvasIsporucujeTovarView>();
            Starost = starost;
        }
    }
}