using DedaMrazovaRadionica.Entiteti;
using NHibernate;
using NHibernate.Linq;
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
        public static IList<VilenjakZaIzraduIgracakaMentor> vratiSveMentore()
        {
            IList<VilenjakZaIzraduIgracakaMentor> mentori = new List<VilenjakZaIzraduIgracakaMentor>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                mentori = s.Query<VilenjakZaIzraduIgracaka>()
                    .Select(vilenjak => new VilenjakZaIzraduIgracakaMentor(vilenjak.ID, vilenjak.JedinstvenoIme, vilenjak.ZemljaPorekla, vilenjak.DatumZaposlenja))
                    .ToList();

            }
            catch (Exception e)
            {
                MessageBox.Show("Neuspelo dodavanje vilenjaka za izradu igracaka!");
            }
            finally { s?.Close(); }
            return mentori;
        }

        public static IList<TimID> vratiNaziveTimova()
        {
            ISession s = null;
            IList<TimID> timovi = new List<TimID>();
            try
            {
                s = DataLayer.GetSession();

                timovi = s.Query<Tim>().Select(tim => new TimID(tim.ID, tim.Naziv)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { s?.Close(); }
            return timovi;
        }

        public static DeoRadionice vratiRadionicu(int id)
        {
            ISession s = null;
            DeoRadionice radionica = null;
            try
            {
                s = DataLayer.GetSession();
                radionica = s.Get<DeoRadionice>(id);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { s?.Close(); }
            return radionica;
        }

        public static Tim vratiTim(int id)
        {
            ISession s = null;
            Tim tim = null;
            try
            {
                s = DataLayer.GetSession();
                tim = s.Get<Tim>(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { s?.Close(); }
            return tim;
        }

        public static IList<DeoRadioniceID> vratiNaziveRadionica()
        {
            ISession s = null;
            IList<DeoRadioniceID> deloviRadionice = new List<DeoRadioniceID>();
            try
            {
                s = DataLayer.GetSession();

                deloviRadionice = s.Query<DeoRadionice>()
                                    .Select(dr => new DeoRadioniceID(dr.ID, dr.Naziv))
                                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { s?.Close(); }
            return deloviRadionice;
        }

        public static bool dodajVilenjakaZaIgracke(VilenjakZaIzraduIgracakaBasic vib)
        {
            ISession s = null;
            VilenjakZaIzraduIgracaka vie = new VilenjakZaIzraduIgracaka();
            try
            {
                s = DataLayer.GetSession();

                vie.DatumZaposlenja = vib.datumZaposlenja;
                vie.ZemljaPorekla = vib.zemljaPorekla;
                vie.DuzinaObuke = vib.duzinaObuke;
                vie.DeoRadionice = vib.deoRadionice;
                vie.ImaMentora = vib.mentor;
                vie.Ocena = vib.ocena;
                vie.JedinstvenoIme = vib.jedinstvenoIme;
                vie.PripadaTimu = vib.pripadaTimu;

                vie.DatumPostavljanja = DateTime.MinValue;
                vie.FlagKoordinator = 0;
                vie.FlagSef = 0;

                s.SaveOrUpdate(vie);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                s?.Close();
            }
            return true;
        }

        public static bool dodajVilenjakaZaIrvase(VilenjakZaIrvaseBasic vib)
        {
            ISession s = null;
            VilenjakZaIrvase vie = new VilenjakZaIrvase();
            try
            {
                s = DataLayer.GetSession();

                vie.JedinstvenoIme = vib.jedinstvenoIme;
                vie.ZemljaPorekla = vib.zemljaPorekla;
                vie.DatumZaposlenja = vib.datumZaposlenja;

                s.SaveOrUpdate(vie);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { s?.Close(); }
            return true;
        }
        public static bool obirisiVilenjakaZaIzraduIgracaka(int id)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                VilenjakZaIzraduIgracaka vilenjak = s.Get<VilenjakZaIzraduIgracaka>(id);
                if(vilenjak != null)
                    s.Delete(vilenjak);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { s?.Close(); }
            return true;
        }
        public static Vilenjak vratiVilenjaka(string ime)
        {
            Vilenjak vilenjak = null;
            vilenjak = vratiVilenjakaZaIrvase(ime);
            if (vilenjak != null)
                return vilenjak;
            vilenjak = vratiVilenjakaZaIzraduIgracaka(ime);
            if (vilenjak != null)
                return vilenjak;
            vilenjak = vratiVilenjakaZaPoklone(ime);
            if (vilenjak != null)
                return vilenjak;
            vilenjak = vratiVilenjakaZaIsporukuPoklona(ime);
            return vilenjak;
            
        }
        public static VilenjakZaIzraduIgracaka vratiVilenjakaZaIzraduIgracaka(int id)
        {
            ISession s = null;
            VilenjakZaIzraduIgracaka vilenjak = null;
            try
            {
                s = DataLayer.GetSession();
                vilenjak = s.Get<VilenjakZaIzraduIgracaka>(id);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally { s?.Close(); }
            return vilenjak;
        }
        
        public static VilenjakZaIzraduIgracaka vratiVilenjakaZaIzraduIgracaka(string ime)
        {
            ISession s = null;
            VilenjakZaIzraduIgracaka vilenjak = null;
            try
            {
                s = DataLayer.GetSession();

                vilenjak = s.Query<VilenjakZaIzraduIgracaka>()
                    .Where(v => v.JedinstvenoIme.Equals(ime))
                    .ToList().First();

                var magicneVestine = s.Query<SpojVilenjakZaIgrackeVestina>()
                                      .Where(skill => skill.VilenjakZaIzraduIgracaka.ID == vilenjak.ID).ToList();
                vilenjak.VilenjakZaIgrackeVestinaSpoj = magicneVestine;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                s?.Close();
            }
            return vilenjak;
        }

        public static VilenjakZaIrvase vratiVilenjakaZaIrvase(string ime)
        {
            ISession s = null;
            VilenjakZaIrvase vilenjak = null;
            try
            {
                s = DataLayer.GetSession();

                vilenjak = s.Query<VilenjakZaIrvase>()
                    .Where(v => v.JedinstvenoIme.Equals(ime))
                    .ToList().First();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                s?.Close();
            }
            return vilenjak;
        }

        public static VilenjakZaIsporukuPoklona vratiVilenjakaZaIsporukuPoklona(string ime)
        {
            ISession s = null;
            VilenjakZaIsporukuPoklona vilenjak = null;
            try
            {
                s = DataLayer.GetSession();

                vilenjak = s.Query<VilenjakZaIsporukuPoklona>()
                    .Where(v => v.JedinstvenoIme.Equals(ime))
                    .ToList().First();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                s?.Close();
            }
            return vilenjak;
        }

        public static VilenjakZaPoklone vratiVilenjakaZaPoklone(string ime)
        {
            ISession s = null;
            VilenjakZaPoklone vilenjak = null;
            try
            {
                s = DataLayer.GetSession();

                vilenjak = s.Query<VilenjakZaPoklone>()
                    .Where(v => v.JedinstvenoIme.Equals(ime))
                    .ToList().First();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                s?.Close();
            }
            return vilenjak;
        }

        public static IList<MagicnaVestina> vratiMagicneVestine()
        {
            ISession s = null;
            IList<MagicnaVestina> lista = null;
            try
            {
                s = DataLayer.GetSession();
                lista = s.Query<MagicnaVestina>().ToList();
            }
            catch (Exception ex)
            {

            }
            finally { s?.Close(); }
            return lista;
        }

        
    }
}
