using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class IrvasIsporucujeTovarView
    {
        public  int ID { get; set; }
        public  IrvasView Irvas { get; set; }
        public  TovarView Tovar { get; set; }

        public IrvasIsporucujeTovarView()
        {

        }

        public IrvasIsporucujeTovarView(int iD, IrvasView irvas, TovarView tovar)
        {
            ID = iD;
            Irvas = irvas;
            Tovar = tovar;
        }
    }
}