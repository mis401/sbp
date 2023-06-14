using DatabaseAccess.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.DTOs
{
    public class DeoRadioniceView
    {
        public  int ID { get; set; }
        public  string Naziv { get; set; }
        public string TipIgracke { get; set; }
        public int BrojAngazovanihVilenjaka { get; set; }
        public VilenjakZaIzraduIgracakaView? Sef { get; set; }
        public IList<IgrackaView> IgrackeIstogTipa { get; set; }
        public IList<MagicnaVestinaView> ZahtevaVestinu { get; set; }
        public IList<VilenjakZaIzraduIgracakaView> VilenjaciZaIzraduIgracaka { get; set; }

        public DeoRadioniceView()
        {
            IgrackeIstogTipa = new List<IgrackaView>();
            ZahtevaVestinu = new List<MagicnaVestinaView>();
            VilenjaciZaIzraduIgracaka = new List<VilenjakZaIzraduIgracakaView>();
        }

        public DeoRadioniceView(DeoRadionice dr)
        {
            ID = dr.ID;
            Naziv = dr.Naziv;
            TipIgracke = dr.TipIgracke;
            BrojAngazovanihVilenjaka = dr.BrojAngazovanihVilenjaka;
            //Sef = new VilenjakZaIzraduIgracakaView(dr.Sef);
            IgrackeIstogTipa = new List<IgrackaView>();
            ZahtevaVestinu = new List<MagicnaVestinaView>();
            VilenjaciZaIzraduIgracaka = new List<VilenjakZaIzraduIgracakaView>();
        }
    }
}
