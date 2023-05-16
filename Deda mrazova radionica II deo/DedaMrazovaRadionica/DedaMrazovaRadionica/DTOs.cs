using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica
{
    public class VilenjakBasic
    {
        public int id;
        public string jedinstvenoIme;
        public string zemljaPorekla;
        public DateTime datumZaposlenja;

        public VilenjakBasic() { }
        public VilenjakBasic(string jedIme, string zemPor, DateTime datZap)
        {
            jedinstvenoIme = jedIme;
            zemljaPorekla = zemPor;
            datumZaposlenja = datZap;
        }
    }

    public class VilenjakZaIrvaseBasic : VilenjakBasic
    {
        public VilenjakZaIrvaseBasic() { }
        public VilenjakZaIrvaseBasic( string jedinstvenoIme, string zemljaPorekla, DateTime datumZaposlenja) : base(jedinstvenoIme, zemljaPorekla, datumZaposlenja)
        {
            
        }
    }

    public class VilenjakZaIsporukuPoklonaBasic : VilenjakBasic
    {
        public VilenjakZaIsporukuPoklonaBasic() { }
        public VilenjakZaIsporukuPoklonaBasic( string jedinstvenoIme, string zemljaPorekla, DateTime datumZaposlenja) : base(jedinstvenoIme, zemljaPorekla, datumZaposlenja)
        {

        }
    }

    public class VilenjakZaIzraduIgracakaMentor : VilenjakBasic
    {
       

        public VilenjakZaIzraduIgracakaMentor() { }
        public VilenjakZaIzraduIgracakaMentor(string jedIme, string zemPor, DateTime datZap) : base(jedIme, zemPor,datZap)
        {

        }
    }

    public class VilenjakZaPokloneBasic :VilenjakBasic
    {
        public VilenjakZaPokloneBasic()
        {

        }
        public VilenjakZaPokloneBasic(string jedIme, string zemPor, DateTime datZap): base(jedIme, zemPor, datZap)
        {

        }
    }
}
