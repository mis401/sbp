using DedaMrazovaRadionica.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DedaMrazovaRadionica
{
    public class DTOManagerBenc
    {
        
        public static bool dodajIrvasa(Irvas irvas)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                s.SaveOrUpdate(irvas);
            }

            catch (Exception e) { MessageBox.Show(e.Message); return false; }
            finally
            {
                s?.Flush();
                s?.Close();
            }
            return true;
        }

        public static bool obrisiIrvasa(string ime)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                var irvas = s.Query<Irvas>().Where(i => i.Ime.Equals(ime)).FirstOrDefault();
                var vilenjaci = s.Query<VilenjakZaIrvase>().Where(v => v.Irvas.ID == irvas.ID).ToList();
                foreach(var vilenjak in vilenjaci)
                {
                    vilenjak.Irvas = null;
                }
                s.Flush();
                s.Delete(irvas);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static IList<Irvas> vratiSveIrvase()
        {
            ISession s = null;
            IList<Irvas> list = new List<Irvas>();
            try
            {
                s = DataLayer.GetSession();
                list = s.Query<Irvas>().ToList();
            }
            catch(Exception ex) { }
            finally { s?.Close(); }
            return list;
        }

        public static bool azurirajIrvasa(Irvas irvas, IrvasDTO iDTO)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                irvas.Ime = iDTO.ime;
                irvas.Nadimak= iDTO.nadimak;
                irvas.Pol = iDTO.pol;
                irvas.DatumRodjenja = iDTO.datumRodjenja;
                s.SaveOrUpdate(irvas);
            }
            catch(Exception ex) { return false; }
            finally { s?.Flush(); s?.Close();}
            return true;
        }
    }
}
