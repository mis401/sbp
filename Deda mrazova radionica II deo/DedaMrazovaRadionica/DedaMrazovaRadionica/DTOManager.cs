using DedaMrazovaRadionica.Entiteti;
using NHibernate;
using Prodavnica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DedaMrazovaRadionica
{
    public class DTOManager
    {
        public static List<VilenjakZaIzraduIgracakaMentor> vratiSveMentore()
        {
            List<VilenjakZaIzraduIgracakaMentor> mentori = new List<VilenjakZaIzraduIgracakaMentor>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VilenjakZaIzraduIgracaka> vilenjaci = from o in s.Query<VilenjakZaIzraduIgracaka>()
                                                            select o;

                foreach (VilenjakZaIzraduIgracaka v in vilenjaci)
                {
                    mentori.Add(new VilenjakZaIzraduIgracakaMentor(v.JedinstvenoIme, v.ZemljaPorekla, v.DatumZaposlenja));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Neuspelo dodavanje vilenjaka za izradu igracaka!");
            }

            return mentori;
        }
    }
}
