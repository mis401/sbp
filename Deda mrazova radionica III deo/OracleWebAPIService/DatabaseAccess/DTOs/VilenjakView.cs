using DatabaseAccess.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class VilenjakView
    {
        public  int ID { get; set; }
        public  string JedinstvenoIme { get; set; }
        public string ZemljaPorekla { get; set; }
        public  DateTime DatumZaposlenja { get; set; }

        public VilenjakView()
        {

        }

        public VilenjakView(Vilenjak v)
        {
            ID = v.ID;
            JedinstvenoIme = v.JedinstvenoIme;
            ZemljaPorekla = v.ZemljaPorekla;
            DatumZaposlenja = v.DatumZaposlenja;
        }
    }
}
