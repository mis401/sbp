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

        public IrvasIsporucujeTovarView(IrvasIsporucujeTovar i)
        {
            ID = i.ID;
            //Irvas = new IrvasView(i.Irvas);
            Tovar = new TovarView(i.Tovar);
        }
    }
}