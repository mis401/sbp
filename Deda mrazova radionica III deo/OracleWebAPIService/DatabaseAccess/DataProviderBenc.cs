using DatabaseAccess.Entiteti;
using NHibernate;
using NHibernate.Linq;
using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FluentNHibernate.Conventions;
using NHibernate.Context;
using FluentNHibernate;
using FluentNHibernate.Utils;
using DatabaseAccess.DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DatabaseAccess
{
    public class DataProviderBenc
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
                //MessageBox.Show("Neuspelo dodavanje vilenjaka za izradu igracaka!");
            }
            finally { s?.Flush(); s?.Close(); }
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
                //MessageBox.Show(ex.Message);
            }
            finally { s?.Flush(); s?.Close(); }
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
            catch (Exception ex) {// MessageBox.Show(ex.Message);
            }
            finally { s?.Flush(); s?.Close(); }
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
                //MessageBox.Show(ex.Message);
            }
            finally { s?.Flush(); s?.Close(); }
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
                //MessageBox.Show(ex.Message);
            }
            finally { s?.Flush(); s?.Close(); }
            return deloviRadionice;
        }

        public static VilenjakZaIzraduIgracaka DodajVilenjakaZaIzraduIgracaka(VilenjakZaIzraduIgracakaView data)
        {
            ISession s = null;
            VilenjakZaIzraduIgracaka vie = new VilenjakZaIzraduIgracaka();
            try
            {
                s = DataLayer.GetSession();
                vie.DatumPostavljanja = data.DatumPostavljanja;
                vie.JedinstvenoIme = data.JedinstvenoIme;
                vie.ZemljaPorekla = data.ZemljaPorekla;
                vie.DatumZaposlenja = data.DatumZaposlenja;
                vie.FlagKoordinator = data.FlagKoordinator;
                vie.FlagSef = data.FlagSef;
                VilenjakZaIzraduIgracaka mentor = null;
                if (data.ImaMentora != null)
                {
                    mentor = s.Query<VilenjakZaIzraduIgracaka>().Where(m => m.ID == data.ImaMentora.ID).FirstOrDefault();
                }
                vie.ImaMentora= mentor;
                vie.Ocena= data.Ocena;
                vie.PripadaTimu = null;
                if(data.PripadaTimu != null)
                    vie.PripadaTimu = s.Query<Tim>().Where(t => t.ID == data.PripadaTimu.ID).FirstOrDefault();
                vie.DeoRadionice = null;
                if(data.DeoRadionice != null)
                    vie.DeoRadionice = s.Query<DeoRadionice>().Where(t => t.ID == data.DeoRadionice.ID).FirstOrDefault();
                foreach(var spoj in data.VilenjakZaIgrackeVestinaSpoj)
                {
                    var vestinaSpoj = new SpojVilenjakZaIgrackeVestina();
                    vestinaSpoj.MagicnaVestina = s.Query<MagicnaVestina>().Where(v => v.ID == spoj.MagicnaVestina.ID).FirstOrDefault();
                    vie.VilenjakZaIgrackeVestinaSpoj.Add(vestinaSpoj);
                }
                foreach(var igracka in data.Igracke)
                {
                    Igracka igrackaEntitet = new Igracka();
                    igrackaEntitet.Tip = igracka.Tip;
                    igrackaEntitet.Opis = igracka.Opis;
                    vie.Igracke.Add(igrackaEntitet);
                }
                s.SaveOrUpdate(vie);
                s?.Flush();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                s?.Close();
            }
            return vie;
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
                //MessageBox.Show(ex.Message);
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }
        public static bool obirisiVilenjakaZaIzraduIgracaka(int id)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                VilenjakZaIzraduIgracaka vilenjak = s.Get<VilenjakZaIzraduIgracaka>(id);
                if (vilenjak != null)
                    s.Delete(vilenjak);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static List<VilenjakZaIrvaseView> VratiVilenjakeZaIrvaseView(string ime = "test")
        {
            ISession s = null;
            List<VilenjakZaIrvaseView> vilenjaci = new List<VilenjakZaIrvaseView>();
            try
            {
                s = DataLayer.GetSession();
                List<VilenjakZaIrvase> listaVilenjaka;
                if (ime.Equals("test"))
                    listaVilenjaka = s.Query<VilenjakZaIrvase>().ToList();
                else
                    listaVilenjaka = s.Query<VilenjakZaIrvase>().Where(elf => elf.JedinstvenoIme.Equals(ime)).ToList();

                foreach (var elf in listaVilenjaka)
                {
                    List<SpojVilenjakZaIrvaseVestinaView> vestine = new List<SpojVilenjakZaIrvaseVestinaView>();
                    foreach (var irvasvestine in elf.VilenjakZaIrvaseVestinaSpoj)
                    {
                        vestine.Add(new SpojVilenjakZaIrvaseVestinaView(irvasvestine));
                    }
                    List<PesmaView> pesme = new List<PesmaView>();
                    foreach (var pesma in elf.Pesme)
                    {
                        pesme.Add(new PesmaView(pesma));
                    }
                    VilenjakZaIrvaseView view = new VilenjakZaIrvaseView(elf);
                    view.VilenjakZaIrvaseVestinaSpoj = vestine;
                    view.Pesme = pesme;
                    vilenjaci.Add(view);
                }
                return vilenjaci;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { s?.Close(); }
        }
        public static List<VilenjakZaIsporukuPoklonaView> VratiSveVilenjakeZaIsporukuView(string ime = "test")
        {
            ISession s = null;
            List<VilenjakZaIsporukuPoklonaView> vilenjaci = new List<VilenjakZaIsporukuPoklonaView>();
            try
            {
                s = DataLayer.GetSession();
                List<VilenjakZaIsporukuPoklona> listaVilenjaka; 
                if(ime.Equals("test"))   
                    listaVilenjaka = s.Query<VilenjakZaIsporukuPoklona>().ToList();
                else
                    listaVilenjaka = s.Query<VilenjakZaIsporukuPoklona>().Where(elf => elf.JedinstvenoIme.Equals(ime)).ToList();

                foreach (var elf in listaVilenjaka)
                {
                    List<SpojVilenjakZaIsporukuVestinaView> vestine = new List<SpojVilenjakZaIsporukuVestinaView>();
                    foreach (var irvasvestine in elf.VilenjakZaIsporukuVestinaSpoj)
                    {
                        vestine.Add(new SpojVilenjakZaIsporukuVestinaView(irvasvestine));
                    }
                    VilenjakZaIsporukuPoklonaView view = new VilenjakZaIsporukuPoklonaView(elf);
                    view.VilenjakZaIsporukuVestinaSpoj = vestine;
                    vilenjaci.Add(view);
                }
                return vilenjaci;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { s?.Close(); }
        }

        public static List<VilenjakZaIzraduIgracakaView> VratiVilenjakeZaIzraduIgracakaView(string ime = "test")
        {
            ISession s = null;
            List<VilenjakZaIzraduIgracakaView> vilenjaci = new List<VilenjakZaIzraduIgracakaView>();
            try
            {
                s = DataLayer.GetSession();
                List<VilenjakZaIzraduIgracaka> listaVilenjaka;
                if(ime.Equals("test"))
                    listaVilenjaka = s.Query<VilenjakZaIzraduIgracaka>().ToList();
                else
                    listaVilenjaka = s.Query<VilenjakZaIzraduIgracaka>().Where(elf => elf.JedinstvenoIme.Equals(ime)).ToList();

                foreach (var elf in listaVilenjaka)
                {

                    List<SpojVilenjakZaIgrackeVestinaView> vestine = new List<SpojVilenjakZaIgrackeVestinaView>();
                    foreach (var irvasvestine in elf.VilenjakZaIgrackeVestinaSpoj)
                    {
                        vestine.Add(new SpojVilenjakZaIgrackeVestinaView(irvasvestine));
                    }
                    List<IgrackaView> igracke = new List<IgrackaView>();
                    foreach (var igracka in elf.Igracke)
                    {
                        igracke.Add(new IgrackaView(igracka));
                    }

                    VilenjakZaIzraduIgracakaView view = new VilenjakZaIzraduIgracakaView(elf);
                    view.VilenjakZaIgrackeVestinaSpoj = vestine;
                    view.Igracke = igracke;
                    view.ImaMentora = null;
                    view.ImaMentora = elf.ImaMentora != null ? new VilenjakZaIzraduIgracakaView(elf.ImaMentora) : null;
                    vilenjaci.Add(view);
                }
                return vilenjaci;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { s?.Close(); }
        }

        public static List<VilenjakZaPokloneView> VratiSveVilenjakeZaPokloneView(string ime = "test")
        {
            ISession s = null;
            List<VilenjakZaPokloneView> vilenjaci = new List<VilenjakZaPokloneView>();
            try
            {
                s = DataLayer.GetSession();
                List<VilenjakZaPoklone> listaVilenjaka;
                if(ime.Equals("test"))
                    listaVilenjaka = s.Query<VilenjakZaPoklone>().ToList();
                else
                    listaVilenjaka = s.Query<VilenjakZaPoklone>().Where(elf => elf.JedinstvenoIme.Equals(ime)).ToList();

                foreach (var elf in listaVilenjaka)
                {
                    List<SpojVilenjakZaPokloneVestinaView> vestine = new List<SpojVilenjakZaPokloneVestinaView>();
                    List<PakovanjePoklonaView> pokloni = new List<PakovanjePoklonaView>();
                    foreach (var irvasvestine in elf.VilenjakZaPokloneVestinaSpoj)
                    {
                        vestine.Add(new SpojVilenjakZaPokloneVestinaView(irvasvestine));
                    }
                    foreach (var poklon in elf.PakovanjePoklona)
                    {
                        pokloni.Add(new PakovanjePoklonaView(poklon));
                    }
                    VilenjakZaPokloneView view = new VilenjakZaPokloneView(elf);
                    view.VilenjakZaPokloneVestinaSpoj = vestine;
                    view.PakovanjePoklona = pokloni;
                    vilenjaci.Add(view);
                }
                return vilenjaci;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { s?.Close(); }
        }
        public static List<VilenjakView> VratiSveVilenjake()
        {
            List<VilenjakView> vilenjaci = new List<VilenjakView>();
            var vilenjaciZaIzraduIgracaka = VratiVilenjakeZaIzraduIgracakaView();
            var vilenjaciZaIrvase = VratiVilenjakeZaIrvaseView();
            var vilenjaciZaPoklone = VratiSveVilenjakeZaPokloneView();
            var vilenjaciZaIsporuku = VratiSveVilenjakeZaIsporukuView();
            foreach(var vilenjak in vilenjaciZaIzraduIgracaka)
            {
                vilenjaci.Add(vilenjak);
            }
            foreach (var vilenjak in vilenjaciZaIrvase)
            {
                vilenjaci.Add(vilenjak);
            }
            foreach (var vilenjak in vilenjaciZaPoklone)
            {
                vilenjaci.Add(vilenjak);
            }
            foreach (var vilenjak in vilenjaciZaIsporuku)
            {
                vilenjaci.Add(vilenjak);
            }
            return vilenjaci;
        }
            

        
        public static VilenjakView VratiVilenjakaView(string ime)
        {
            VilenjakView vilenjak = null;

            vilenjak = vratiVilenjakaZaIrvaseView(ime);
            //MessageBox.Show("1");
            if (vilenjak != null)
                return vilenjak;
            vilenjak = vratiVilenjakaZaIzraduIgracakaView(ime);
            //MessageBox.Show("2");
            if (vilenjak != null)
                return vilenjak;
            vilenjak = vratiVilenjakaZaPokloneView(ime);
            //MessageBox.Show("3");
            if (vilenjak != null)
                return vilenjak;
            vilenjak = vratiVilenjakaZaIsporukuPoklonaView(ime);
            //MessageBox.Show("4");
            if (vilenjak != null)
                return vilenjak;
            throw new Exception("Ne postoji vilenjak sa imenom " + ime);
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
            finally { s?.Flush(); s?.Close(); }
            return vilenjak;
        }

        public static VilenjakZaIzraduIgracakaView vratiVilenjakaZaIzraduIgracakaView(string ime)
        {
            ISession s = null;
            VilenjakZaIzraduIgracakaView vilenjakDTO = null;
            IList<SpojVilenjakZaIgrackeVestinaView> vestine = new List<SpojVilenjakZaIgrackeVestinaView>();
            try
            {
                s = DataLayer.GetSession();

                var vilenjak = s.Query<VilenjakZaIzraduIgracaka>()
                    .Where(v => v.JedinstvenoIme.Equals(ime))
                    .ToList().FirstOrDefault();

                if (vilenjak == null)
                {
                    throw new Exception("Ne postoji vilenjak sa imenom " + ime);
                }
                if (!vilenjak.VilenjakZaIgrackeVestinaSpoj.IsEmpty())
                {
                    var vestineSpojevi = vilenjak.VilenjakZaIgrackeVestinaSpoj;
                    foreach (var vestina in vestineSpojevi)
                    {
                        vestine.Add(new SpojVilenjakZaIgrackeVestinaView(vestina));

                    }
                }
                

                VilenjakZaIzraduIgracakaView view = new VilenjakZaIzraduIgracakaView(vilenjak);
                view.VilenjakZaIgrackeVestinaSpoj = vestine;
                view.ImaMentora = null;
                if(vilenjak.ImaMentora != null)
                    view.ImaMentora = new VilenjakZaIzraduIgracakaView(vilenjak.ImaMentora);

            }
            catch (Exception ex)
            {
                throw;
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                s?.Close();
            }
            return vilenjakDTO;
        }
        public static VilenjakZaIrvaseBasic vratiVilenjakaZaIrvaseBasic(string ime)
        {
            ISession s = null;
            VilenjakZaIrvase vilenjak = null;
            VilenjakZaIrvaseBasic v = null;
            try
            {
                s = DataLayer.GetSession();

                vilenjak = s.Query<VilenjakZaIrvase>()
                    .Where(elf => elf.JedinstvenoIme.Equals(ime))
                    .ToList().First();
                vilenjak.Irvas.Starost = (int)DateTime.Now.Subtract(vilenjak.Irvas.DatumRodjenja).TotalDays;
                IrvasDTO irvas = new IrvasDTO(vilenjak.Irvas.ID, vilenjak.Irvas.Ime, vilenjak.Irvas.Nadimak, vilenjak.Irvas.Pol, vilenjak.Irvas.Starost);
                v = new VilenjakZaIrvaseBasic(vilenjak.ID, vilenjak.JedinstvenoIme, vilenjak.ZemljaPorekla, vilenjak.DatumZaposlenja, irvas);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                s?.Flush(); s?.Close();
            }
            return v;
        }
        //stara funkcija iz druge faze
        public static VilenjakZaIrvaseSaVestinama vratiVilenjakaZaIrvaseSaVestinama(string ime)
        {
            return null;
        }

        public static VilenjakZaIrvaseView vratiVilenjakaZaIrvaseView(string ime)
        {
            ISession s = null;
            VilenjakZaIrvase vilenjak = null;
            VilenjakZaIrvaseView v = null;
            try
            {
                s = DataLayer.GetSession();
                vilenjak = s.Query<VilenjakZaIrvase>().Where(elv => elv.JedinstvenoIme.Equals(ime)).ToList().FirstOrDefault();
                if (vilenjak == null)
                    throw new Exception("Nema vilenjaka sa tim imenom");
                IList<SpojVilenjakZaIrvaseVestinaView> vestine;
                IList<PesmaView> pesmeViews =  new List<PesmaView>();
                if (!vilenjak.VilenjakZaIrvaseVestinaSpoj.IsEmpty())
                {
                    var vestineSpojevi = vilenjak.VilenjakZaIrvaseVestinaSpoj;
                    vestine = new List<SpojVilenjakZaIrvaseVestinaView>();
                    foreach(var item in vestineSpojevi)
                    {
                        vestine.Add(new SpojVilenjakZaIrvaseVestinaView(item));
                    }
                }
                else
                {
                    vestine = new List<SpojVilenjakZaIrvaseVestinaView>();
                }
                if (!vilenjak.Pesme.IsEmpty())
                {
                    foreach(var pesma in vilenjak.Pesme)
                    {
                        var pesmaView = new PesmaView(pesma);
                        pesmeViews.Add(pesmaView);
                    }
                }
                else
                {
                    pesmeViews = new List<PesmaView>();
                }
                
                v = new VilenjakZaIrvaseView(vilenjak);
                v.VilenjakZaIrvaseVestinaSpoj = vestine;
                v.Pesme = pesmeViews;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return v;
        }

        public static VilenjakZaIsporukuPoklonaView vratiVilenjakaZaIsporukuPoklonaView(string ime)
        {
            ISession s = null;
            VilenjakZaIsporukuPoklona vilenjak = null;
            IList<SpojVilenjakZaIsporukuVestinaView> vestine = null;
            VilenjakZaIsporukuPoklonaView v = null;
            try
            {
                s = DataLayer.GetSession();

                vilenjak = s.Query<VilenjakZaIsporukuPoklona>()
                    .Where(v => v.JedinstvenoIme.Equals(ime))
                    .ToList().First();


                if (!vilenjak.VilenjakZaIsporukuVestinaSpoj.IsEmpty())
                {
                    var vestineSpojevi = vilenjak.VilenjakZaIsporukuVestinaSpoj;
                    vestine = new List<SpojVilenjakZaIsporukuVestinaView>();
                    foreach (var spoj in vestineSpojevi)
                    {
                        vestine.Add(new SpojVilenjakZaIsporukuVestinaView(spoj));
                    }
                }


                v = new VilenjakZaIsporukuPoklonaView(vilenjak);
                v.VilenjakZaIsporukuVestinaSpoj = vestine;
            }
            catch (Exception ex)
            {
                throw;
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                s?.Close();
            }
            return v;
        }

        public static VilenjakZaPokloneView vratiVilenjakaZaPokloneView(string ime)
        {
            ISession s = null;
            VilenjakZaPoklone vilenjak = null;
            IList<SpojVilenjakZaPokloneVestinaView> vestine = new List<SpojVilenjakZaPokloneVestinaView>();
            VilenjakZaPokloneView v = null;
            try
            {
                s = DataLayer.GetSession();

                vilenjak = s.Query<VilenjakZaPoklone>()
                    .Where(elf => elf.JedinstvenoIme.Equals(ime))
                    .ToList().First();
                if(vilenjak == null)
                {
                    throw new Exception("Nema vilenjaka sa imenom" + ime);
                }

                if (!vilenjak.VilenjakZaPokloneVestinaSpoj.IsEmpty())
                {
                    var vestineSpojevi = vilenjak.VilenjakZaPokloneVestinaSpoj;
                    vestine = new List<SpojVilenjakZaPokloneVestinaView>();
                    foreach (var item in vestineSpojevi)
                    {
                        vestine.Add(new SpojVilenjakZaPokloneVestinaView(item));
                    }
                }
                else
                {
                    vestine = new List<SpojVilenjakZaPokloneVestinaView>();
                }
                
                var pokloni = new List<PakovanjePoklonaView>();
                if(vilenjak.PakovanjePoklona != null)
                {
                    foreach(var poklon in vilenjak.PakovanjePoklona)
                    {
                        pokloni.Add(new PakovanjePoklonaView(poklon));
                    }
                }

                v = new VilenjakZaPokloneView(vilenjak);
                v.PakovanjePoklona = pokloni;
                v.VilenjakZaPokloneVestinaSpoj = vestine;

            }
            catch (Exception ex)
            {
                throw;
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                s?.Close();
            }
            return v;
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
            finally { s?.Flush(); s?.Close(); }
            return lista;
        }

        public static bool dodajVilenjakaZaIsporukuPoklona(VilenjakZaIsporukuPoklona v)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                s.SaveOrUpdate(v);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }


        public static bool dodajVilenjakaZaPripremuPoklona(VilenjakZaPoklone v)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                s.SaveOrUpdate(v);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }
        
        //dodala sam datum prijama i slanja

        public static IList<PismoPregled> vratiSvaPisma()
        {
            IList<PismoPregled> pisma = new List<PismoPregled>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();



                pisma = s.Query<Pismo>()
                .Select(pismo => new PismoPregled(pismo.ID, pismo.Tekst, pismo.IndeksDobrote,pismo.DatumPrijema, pismo.DatumSlanja, pismo.PripadaDetetu))
                .ToList();



            }
            catch (Exception e)
            {
                //MessageBox.Show("Neuspelo!");
            }
            finally { s?.Flush(); s?.Close(); }
            return pisma;

        }

        public static IList<DeteBasic> vratiSvuDecu()
        {
            IList<DeteBasic> deca = new List<DeteBasic>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();



                deca = s.Query<Dete>()
                .Select(d => new DeteBasic(d.Ime, d.Prezime, d.Grad, d.Drzava, d.Adresa, d.DatumRodjenja))
                .ToList();



            }
            catch (Exception e)
            {
                //MessageBox.Show("Neuspelo!");
            }
            finally { s?.Flush(); s?.Close(); }
            return deca;
        }


        public static Poklon dodajPoklon(PoklonBasic poklon)
        {
            ISession s = null;
            Poklon p = null;
            try
            {
                s = DataLayer.GetSession();
                p = new Poklon();
                p.Boja = poklon.boja;
                p.Posveta = poklon.posveta;
                p.ZaListuZelja = poklon.pripadaListiZelja;
                p.PripadaTovaru = poklon.pripadaTovaru;

                s.SaveOrUpdate(p);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

            }
            finally { s?.Flush(); s?.Close(); }
            return p;
        }
        public static ListaZelja dodajListuZelja(ListaZeljaBasic lz)
        {
            ISession s = null;
            ListaZelja listazelja = new ListaZelja();
            try
            {
                s = DataLayer.GetSession();

                listazelja.PripadaPismu = lz.pismo;

                s.SaveOrUpdate(listazelja);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ovo pismo vec ima svoju listu zelja!");
                return null;
            }
            finally { s?.Close(); }
            return listazelja;
        }

        public static IList<ListaZeljaBasic> vratiListeZelja()
        {
            IList<ListaZeljaBasic> liste = new List<ListaZeljaBasic>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                liste = s.Query<ListaZelja>()
                    .Select(l => new ListaZeljaBasic())
                    .ToList();

            }
            catch (Exception e)
            {
                //MessageBox.Show("Neuspelo dodavanje vilenjaka za izradu igracaka!");
            }
            finally { s?.Flush(); s?.Close(); }
            return liste;
        }

        public static Tovar dodajTovar(TovarBasic tb)
        {
            ISession s = null;
            Tovar t = new Tovar();
            try
            {
                s = DataLayer.GetSession();

                t.Grad = tb.Grad;

                s.SaveOrUpdate(t);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally { s?.Flush(); s?.Close(); }
            return t;
        }

        public static Pismo vratiPismoID(int ID)
        {
            ISession s = null;
            Pismo pismo = null;
            try
            {
                s = DataLayer.GetSession();

                pismo = s.Query<Pismo>()
                    .Where(p => p.ID.Equals(ID))
                    .ToList().First();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                s?.Flush(); s?.Close();
            }
            return pismo;
        }


        //-----------------------------------

        public static MagicnaVestina vratiMagicnuVestinu(string naziv)
        {
            ISession s = null;
            MagicnaVestina mv = null;
            try
            {
                s = DataLayer.GetSession();
                mv = s.Query<MagicnaVestina>()
                    .Where(m => m.Naziv.Equals(naziv))
                    .ToList().FirstOrDefault();

            }
            catch (Exception ex)
            {

            }
            finally { s?.Flush(); s?.Close(); }
            return mv;
        }

        public static bool promeniImeVilenjaku(string novoIme, VilenjakBasic vb)
        {
            ISession s = null;
            Vilenjak vilenjak = null;
            try
            {
                s = DataLayer.GetSession();

                vilenjak = s.Query<Vilenjak>()
                    .Where(v => v.JedinstvenoIme
                    .Equals(vb.jedinstvenoIme)).ToList().FirstOrDefault();
                vilenjak.JedinstvenoIme = novoIme;
                s.SaveOrUpdate(vilenjak);


            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s.Flush(); s?.Flush(); s?.Close(); }
            return true;
        }

        public static bool dodajVestinuVilenjaku(string imeVestine, VilenjakBasic vilenjakDTO)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                var vestina = s.Query<MagicnaVestina>()
                    .Where(mv => mv.Naziv.Equals(imeVestine)).FirstOrDefault();

                var vilenjak = s.Query<Vilenjak>()
                    .Where(v => v.JedinstvenoIme.Equals(vilenjakDTO.jedinstvenoIme)).FirstOrDefault();

                if (vilenjak is VilenjakZaIrvase)
                {
                    var spoj = new SpojVilenjakZaIrvaseVestina();
                    spoj.VilenjakZaIrvase = vilenjak as VilenjakZaIrvase;
                    spoj.MagicnaVestina = vestina;
                    (vilenjak as VilenjakZaIrvase).VilenjakZaIrvaseVestinaSpoj.Add(spoj);
                }
                else if (vilenjak is VilenjakZaIzraduIgracaka)
                {
                    var spoj = new SpojVilenjakZaIgrackeVestina();
                    spoj.VilenjakZaIzraduIgracaka = vilenjak as VilenjakZaIzraduIgracaka;
                    spoj.MagicnaVestina = vestina;
                    (vilenjak as VilenjakZaIzraduIgracaka).VilenjakZaIgrackeVestinaSpoj.Add(spoj);
                }
                else if (vilenjak is VilenjakZaPoklone)
                {
                    var spoj = new SpojVilenjakZaPokloneVestina();
                    spoj.VilenjakZaPoklone = vilenjak as VilenjakZaPoklone;
                    spoj.MagicnaVestina = vestina;
                    (vilenjak as VilenjakZaPoklone).VilenjakZaPokloneVestinaSpoj.Add(spoj);
                }
                else if (vilenjak is VilenjakZaIsporukuPoklona)
                {
                    var spoj = new SpojVilenjakZaIsporukuVestina();
                    spoj.VilenjakZaIsporukuPoklona = vilenjak as VilenjakZaIsporukuPoklona;
                    spoj.MagicnaVestina = vestina;
                    (vilenjak as VilenjakZaIsporukuPoklona).VilenjakZaIsporukuVestinaSpoj.Add(spoj);
                }
                else
                {
                    return false;
                }
                s.SaveOrUpdate(vilenjak);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static bool ukloniVestinuVilenjaku(string imeVestine, VilenjakBasic vilenjakDTO)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                var vestina = s.Query<MagicnaVestina>()
                    .Where(mv => mv.Naziv.Equals(imeVestine)).FirstOrDefault();

                var vilenjak = s.Query<Vilenjak>()
                    .Where(v => v.JedinstvenoIme.Equals(vilenjakDTO.jedinstvenoIme)).FirstOrDefault();

                if (vilenjak is VilenjakZaIrvase)
                {
                    var spoj = s.Query<SpojVilenjakZaIrvaseVestina>()
                        .Where(skill => skill.MagicnaVestina.ID == vestina.ID)
                        .FirstOrDefault();
                    s.Delete(spoj);
                }
                else if (vilenjak is VilenjakZaIzraduIgracaka)
                {
                    var spoj = s.Query<SpojVilenjakZaIgrackeVestina>()
                        .Where(skill => skill.MagicnaVestina.ID == vestina.ID)
                        .FirstOrDefault();
                    s.Delete(spoj);
                }
                else if (vilenjak is VilenjakZaPoklone)
                {
                    var spoj = s.Query<SpojVilenjakZaPokloneVestina>()
                        .Where(skill => skill.MagicnaVestina.ID == vestina.ID)
                        .FirstOrDefault();
                    s.Delete(spoj);
                }
                else if (vilenjak is VilenjakZaIsporukuPoklona)
                {
                    var spoj = s.Query<SpojVilenjakZaIsporukuVestina>()
                        .Where(skill => skill.MagicnaVestina.ID == vestina.ID)
                        .FirstOrDefault();
                    s.Delete(spoj);
                }
                else
                {
                    return false;
                }
                s.SaveOrUpdate(vilenjak);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static bool promeniIrvasaVilenjaku(string noviIrvas, VilenjakBasic vb)
        {
            ISession s = null;
            {
                try
                {
                    s = DataLayer.GetSession();

                    VilenjakZaIrvase vilenjak = s.Query<VilenjakZaIrvase>().Where(v => v.JedinstvenoIme.Equals(vb.jedinstvenoIme)).FirstOrDefault();
                    var irvas = s.Query<Irvas>().Where(i => i.Nadimak.Equals(noviIrvas)).FirstOrDefault();

                    vilenjak.Irvas = irvas;

                    s.SaveOrUpdate(vilenjak);
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally { s?.Flush(); s?.Close(); }
                return true;
            }
        }

        public static IList<PesmaDTO> vratiPesme()
        {
            ISession s = null;
            IList<PesmaDTO> pesme = null;
            try
            {
                s = DataLayer.GetSession();

                pesme = s.Query<Pesma>().Select(p => new PesmaDTO(p.ID, p.Naziv, p.Tekst)).ToList();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Greska u vracanju pesama");
            }
            finally
            {
                s.Flush(); s.Close();
            }
            return pesme;
        }

        public static bool ukloniPesmuVilenjaku(string ime, VilenjakBasic vb)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                //VilenjakZaIrvase vilenjak = s.Query<VilenjakZaIrvase>().Where(v => v.JedinstvenoIme.Equals(vb.jedinstvenoIme)).FirstOrDefault();

                var pesma = s.Query<Pesma>().Where(p => p.Naziv.Equals(ime)).FirstOrDefault();

                s.Delete(pesma);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s.Flush(); s.Close(); }
            return true;
        }

        public static bool dodajPesmuVilenjaku(string ime, VilenjakBasic vb)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                VilenjakZaIrvase vilenjak = s.Query<VilenjakZaIrvase>().Where(v => v.ID == vb.id).FirstOrDefault();
                Pesma pesma = s.Query<Pesma>().Where(p => p.Naziv.Equals(ime)).FirstOrDefault();

                vilenjak.Pesme.Add(pesma);
                s.SaveOrUpdate(vilenjak);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s.Flush(); s.Close(); }
            return true;
        }

        public static IList<PoklonBasic> vratiPokloneVilenjaka(VilenjakBasic vb)
        {
            ISession s = null;
            IList<PoklonBasic> pokloni = new List<PoklonBasic>();
            VilenjakZaPoklone vilenjak = null;
            try
            {
                s = DataLayer.GetSession();

                vilenjak = s.Query<VilenjakZaPoklone>().Where(v => v.ID == vb.id).FirstOrDefault();

                IList<PakovanjePoklona> spakovaniPokloni = new List<PakovanjePoklona>();
                foreach (var item in vilenjak.PakovanjePoklona)
                {
                    spakovaniPokloni.Add(item);
                }

                pokloni = spakovaniPokloni.Select(p => new PoklonBasic(p.Poklon.ID, p.Poklon.Boja, p.Poklon.Posveta, p.Poklon.ZaListuZelja, p.Poklon.PripadaTovaru, p.Poklon.PripadaTovaru.Grad, p.Poklon.ZaListuZelja.PripadaPismu.PripadaDetetu.Ime)).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                s.Flush();
                s.Close();
            }
            return pokloni;
        }
        public static Igracka dodajIgracka(IgrackaPregled igr)
        {
            ISession s = null;
            Igracka igracka = new Igracka();
            try
            {
                s = DataLayer.GetSession();
                igracka.RedniBroj = igr.redniBroj;
                igracka.Tip = igr.tip;
                igracka.Opis = igr.opis;
                igracka.PripadaPoklonu = igr.pripadaPoklonu;
                igracka.PripadaListiZelja = igr.pripadaListiZelja;
                igracka.Vilenjak = igr.vilenjak;
                igracka.IzradjenaUDeluRadionice = igr.izradjenaUDeluRadionice;

                s.SaveOrUpdate(igracka);

            }
            catch (Exception ex)
            {
                return null;
            }
            finally { s?.Close(); }
            return igracka;
        }

        public static Poklon vratiPoklon(int ID)
        {
            ISession s = null;
            Poklon poklon = null;
            try
            {
                s = DataLayer.GetSession();

                poklon = s.Query<Poklon>()
                    .Where(v => v.ID.Equals(ID))
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
            return poklon;
        }

        public static ListaZelja vratiListuZelja(int ID)
        {
            ISession s = null;
            ListaZelja listaZelja = null;
            try
            {
                s = DataLayer.GetSession();

                listaZelja = s.Query<ListaZelja>()
                    .Where(v => v.ID.Equals(ID))
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
            return listaZelja;
        }



        /*    public static Poklon vratiPoklonSaNajvecimID()
            {
                ISession s = null;
                Poklon maxPoklon = null;
                IList<Poklon> pokloni = vratiPoklone();
                try
                {
                    s = DataLayer.GetSession();
                    maxPoklon = pokloni.OrderByDescending(z => z.ID).FirstOrDefault();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    s?.Close();
                }
                return maxPoklon;
            }*/

        public static IList<Poklon> vratiPoklone()
        {
            IList<Poklon> pokloni = new List<Poklon>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                pokloni = s.Query<Poklon>()
                    .Select(l => new Poklon())
                    .ToList();

            }
            catch (Exception e)
            {
                //MessageBox.Show("Neuspelo dodavanje vilenjaka za izradu igracaka!");
            }
            finally { s?.Flush(); s?.Close(); }
            return pokloni;
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
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally { s?.Close(); }
            return vilenjak;
        }


        public static bool unapredjenjeUSefa(VilenjakBasic vb)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                var ve = s.Get<VilenjakZaIzraduIgracaka>(vb.id);
                ve.FlagSef = 1;
                ve.DatumPostavljanja = DateTime.Now;
                s.SaveOrUpdate(ve);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                s?.Flush();
                s?.Close();
            }
            return true;
        }



        public static bool unapredjenjeUKoordinatora(VilenjakBasic vb)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                var ve = s.Get<VilenjakZaIzraduIgracaka>(vb.id);
                ve.FlagKoordinator = 1;
                s.SaveOrUpdate(ve);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                s?.Flush();
                s?.Close();
            }
            return true;
        }


        public static bool izmenaTima(VilenjakBasic vb, string noviTim)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                var ve = s.Get<VilenjakZaIzraduIgracaka>(vb.id);
                var tim = s.Query<Tim>().Where(t => t.Naziv.Equals(noviTim)).FirstOrDefault();
                ve.PripadaTimu = tim;
                ve.FlagKoordinator = 0;
                s.SaveOrUpdate(ve);
            }
            catch (Exception ex) { return false; }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static bool izmenaRadionice(VilenjakBasic vb, string novaRadionica)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                var ve = s.Get<VilenjakZaIzraduIgracaka>(vb.id);
                var rad = s.Query<DeoRadionice>().Where(r => r.Naziv.Equals(novaRadionica)).FirstOrDefault();
                ve.DeoRadionice = rad;
                ve.FlagSef = 0;
                s.SaveOrUpdate(ve);
            }
            catch (Exception ex) { return false; }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static bool obrisiVilenjaka(string ime)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                var vilenjak = s.Query<Vilenjak>().Where(v => v.JedinstvenoIme.Equals(ime)).FirstOrDefault();

                if (vilenjak is VilenjakZaIzraduIgracaka)
                {
                    var ucenici = s.Query<VilenjakZaIzraduIgracaka>().Where(v => v.ImaMentora.ID == vilenjak.ID).ToList();
                    foreach (var ucenik in ucenici)
                    {
                        ucenik.ImaMentora = null;
                        s.SaveOrUpdate(ucenik);
                    }
                }
                s.Flush();
                s.Delete(vilenjak);
            }
            catch (Exception ex) { return false; }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static IList<VilenjakZaIzraduIgracakaPoklon> vratiSveVilenjakeZaIgracke()
        {
            IList<VilenjakZaIzraduIgracakaPoklon> vilenjak = new List<VilenjakZaIzraduIgracakaPoklon>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();



                vilenjak = s.Query<VilenjakZaIzraduIgracaka>()
                .Select(v => new VilenjakZaIzraduIgracakaPoklon(v.ID, v.JedinstvenoIme, v.ZemljaPorekla, v.DatumZaposlenja))
                .ToList();



            }
            catch (Exception e)
            {
                //MessageBox.Show("Neuspelo!");
            }
            finally { s?.Flush(); s?.Close(); }
            return vilenjak;
        }

        public static bool obrisiPismo(int id)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                Pismo pismo = s.Get<Pismo>(id);
                if (pismo != null)
                    s.Delete(pismo);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static bool dodajDete(DeteRoditeljDTO dete)
        {
            ISession s = null;
            Dete d = new Dete();
            try
            {
                s = DataLayer.GetSession();

                d.Ime = dete.ime;
                d.Prezime = dete.prezime;
                d.Grad = dete.grad;
                d.Drzava = dete.drzava;
                d.Adresa = dete.adresa;
                d.DatumRodjenja = dete.datumRodjenja;
                dete.roditelj1.Dete = d;
                dete.roditelj2.Dete = d;
                d.Roditelji.Add(dete.roditelj1);
                d.Roditelji.Add(dete.roditelj2);
                s.SaveOrUpdate(d);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }


        //stara metoda
        public static bool dodajPismo(PismoBasic pismo)
        {
            ISession s = null;
            Pismo p = new Pismo();
            try
            {
                s = DataLayer.GetSession();
                var listaPisama = s.Query<Pismo>().Where(poslatoPismo => poslatoPismo.PripadaDetetu.ID == pismo.dete.ID).ToList();
                foreach (var item in listaPisama)
                {
                    if (item.DatumSlanja.Year == pismo.datumSlanja.Year)
                    {
                        throw new Exception("Dete je vec slalo pesmo ove godine");
                    }
                }

                var dete = s.Query<Dete>().Where(d => d.ID == pismo.dete.ID).FirstOrDefault();

                p.Tekst = pismo.tekst;
                p.IndeksDobrote = pismo.indDobrote;
                p.DatumSlanja = pismo.datumSlanja;
                p.DatumPrijema = pismo.datumPrijema;
                p.PripadaDetetu = dete;


                s.SaveOrUpdate(p);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }
        //nova metoda
        public static bool dodajPismo(PismoView pismo)
        {
            ISession s = null;
            Pismo p = new Pismo();
            try
            {
                s = DataLayer.GetSession();
                var listaPisama = s.Query<Pismo>().Where(poslatoPismo => poslatoPismo.PripadaDetetu.ID == pismo.PripadaDetetu.ID).ToList();
                foreach (var item in listaPisama)
                {
                    if (item.DatumSlanja.Year == pismo.DatumSlanja.Year)
                    {
                        throw new Exception("Dete je vec slalo pesmo ove godine");
                    }
                }

                var dete = s.Query<Dete>().Where(d => d.ID == pismo.PripadaDetetu.ID).FirstOrDefault();

                p.Tekst = pismo.Tekst;
                p.IndeksDobrote = pismo.IndeksDobrote;
                p.DatumSlanja = pismo.DatumSlanja;
                p.DatumPrijema = pismo.DatumPrijema;
                p.PripadaDetetu = dete;


                s.SaveOrUpdate(p);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }
        public static bool dodajDeoRadionice(DeoRadioniceBasic dr)
        {
            ISession s = null;
            DeoRadionice deoR = new DeoRadionice();
            try
            {
                s = DataLayer.GetSession();

                deoR.Naziv = dr.naziv;
                deoR.TipIgracke = dr.tipIgr;


                s.SaveOrUpdate(deoR);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static IList<DeoRadioniceBasic> vratiSveRadionice()
        {
            IList<DeoRadioniceBasic> rad = new List<DeoRadioniceBasic>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                rad = s.Query<DeoRadionice>()
                    .Select(r => new DeoRadioniceBasic(r.Naziv, r.TipIgracke))
                    .ToList();

            }
            catch (Exception e)
            {
               // MessageBox.Show("Neuspelo dodavanje vilenjaka za izradu igracaka!");
            }
            finally { s?.Flush(); s?.Close(); }
            return rad;
        }

        public static bool obrisiDeoRadionice(string naziv)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                var radionica = s.Query<DeoRadionice>().Where(i => i.Naziv.Equals(naziv)).FirstOrDefault();
                var vilenjaci = radionica.VilenjaciZaIzraduIgracaka;
                var nerasporedjen = s.Query<DeoRadionice>().Where(dr => dr.Naziv.Equals("Nerasporedjen")).FirstOrDefault();
                foreach(var vilenjak in vilenjaci)
                {
                    vilenjak.DeoRadionice = nerasporedjen;
                }
                var magicnaVestina = s.Query<MagicnaVestina>().Where(mv => mv.PotrebnaDeluRadionice.ID == radionica.ID).ToList();
                foreach(var mv in magicnaVestina)
                {
                    mv.PotrebnaDeluRadionice = nerasporedjen;
                }
                radionica.Sef = null;
                radionica.VilenjaciZaIzraduIgracaka = null;

                s.Flush();
                s.Delete(radionica);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static DeoRadionice vratiRadionicu(string naziv)
        {
            ISession s = null;
            DeoRadionice rad = null;
            try
            {
                s = DataLayer.GetSession();
                rad = s.Query<DeoRadionice>()
                    .Where(v => v.Naziv.Equals(naziv))
                    .ToList().First();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally { s?.Close(); }
            return rad;
        }

        public static IList<VilenjakZaIzraduIgracaka> vratiRadnike(int IDRadionice)
        {
            ISession s = null;
            IList<VilenjakZaIzraduIgracaka> vilenjaci = new List<VilenjakZaIzraduIgracaka>();
            try
            {
                s = DataLayer.GetSession();
                vilenjaci = s.Query<VilenjakZaIzraduIgracaka>()
                    .Where(v => v.DeoRadionice.ID.Equals(IDRadionice))
                    .ToList();
            }
            catch(Exception ex)
            {
                ///MessageBox.Show(ex.Message);
            }
            finally { s?.Close(); }
            return vilenjaci;
        }

        public static bool dodajTim(TimID t)
        {
            ISession s = null;
            Tim tim = new Tim();
            try
            {
                s = DataLayer.GetSession();

                tim.Naziv = t.naziv;


                s.SaveOrUpdate(tim);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static bool obrisiTim(string naziv)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                var tim = s.Query<Tim>().Where(i => i.Naziv.Equals(naziv)).FirstOrDefault();
                var vilenjaci = tim.Vilejnaci;
                var nerasporedjen = s.Query<Tim>().Where(dr => dr.Naziv.Equals("Nerasporedjen")).FirstOrDefault();
                foreach (var vilenjak in vilenjaci)
                {
                    vilenjak.PripadaTimu = nerasporedjen;
                }

                s.Flush();
                s.Delete(tim);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static bool dodajIrvasa(Irvas irvas)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                s.SaveOrUpdate(irvas);
            }

            catch (Exception e)
            { //MessageBox.Show(e.Message);
                return false;
            }
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
                foreach (var vilenjak in vilenjaci)
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
            catch (Exception ex) { }
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
                irvas.Nadimak = iDTO.nadimak;
                irvas.Pol = iDTO.pol;
                irvas.DatumRodjenja = iDTO.datumRodjenja;
                s.SaveOrUpdate(irvas);
            }
            catch (Exception ex) { return false; }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static bool DodajVilenjakaZaIsporukuPoklona(VilenjakZaIsporukuPoklonaView vilenjak)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                var v = new VilenjakZaIsporukuPoklona();
                v.JedinstvenoIme = vilenjak.JedinstvenoIme;
                v.ZemljaPorekla = vilenjak.ZemljaPorekla;
                v.DatumZaposlenja = vilenjak.DatumZaposlenja;
            
                v.Tovar = s.Query<Tovar>().Where(t => t.ID == vilenjak.Tovar.ID).FirstOrDefault();

                foreach (var spoj in v.VilenjakZaIsporukuVestinaSpoj)
                {
                    var vestinaSpoj = new SpojVilenjakZaIsporukuVestina();
                    vestinaSpoj.MagicnaVestina = s.Query<MagicnaVestina>().Where(v => v.ID == spoj.MagicnaVestina.ID).FirstOrDefault();
                    v.VilenjakZaIsporukuVestinaSpoj.Add(vestinaSpoj);
                }
                s.SaveOrUpdate(v);
                s.Flush();
            }
            catch(Exception ex)
            {
                throw;
            }
            finally { s.Close(); }
            return true;
        }

        public static bool DodajVilenjakaZaIrvase(VilenjakZaIrvaseView vilenjak)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                var v = new VilenjakZaIrvase();
                v.JedinstvenoIme = vilenjak.JedinstvenoIme;
                v.ZemljaPorekla = vilenjak.ZemljaPorekla;
                v.DatumZaposlenja = vilenjak.DatumZaposlenja;
                foreach(var pesma in vilenjak.Pesme)
                {
                    var pesmaEntitet = s.Query<Pesma>().Where(p => p.ID == pesma.ID).FirstOrDefault();
                    v.Pesme.Add(pesmaEntitet);
                }
                foreach(var spoj in vilenjak.VilenjakZaIrvaseVestinaSpoj)
                {
                    var spojEntitet = new SpojVilenjakZaIrvaseVestina();
                    spojEntitet.ID = spoj.ID;
                    spojEntitet.MagicnaVestina = new MagicnaVestina();
                    spojEntitet.VilenjakZaIrvase = v;
                    v.VilenjakZaIrvaseVestinaSpoj.Add(spojEntitet);
                }
                s.SaveOrUpdate(vilenjak);
                s.Flush();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { s.Close(); }
            return true;
        }



        public static void DodajVilenjakaZaPoklone(VilenjakZaPokloneView vilenjak)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                var v = new VilenjakZaPoklone();
                v.JedinstvenoIme = vilenjak.JedinstvenoIme;
                v.ZemljaPorekla = vilenjak.ZemljaPorekla;
                v.DatumZaposlenja = vilenjak.DatumZaposlenja;
                foreach (var pakovanje in vilenjak.PakovanjePoklona)
                {
                    var pakovanjeEntitet = new PakovanjePoklona();
                    pakovanjeEntitet.ID = pakovanje.ID;
                    pakovanjeEntitet.VilenjakZaPoklone = v;
                    v.PakovanjePoklona.Add(pakovanjeEntitet);
                }
                foreach (var spoj in vilenjak.VilenjakZaPokloneVestinaSpoj)
                {
                    var spojEntitet = new SpojVilenjakZaPokloneVestina();
                    spojEntitet.ID = spoj.ID;
                    spojEntitet.MagicnaVestina = new MagicnaVestina();
                    spojEntitet.VilenjakZaPoklone = v;
                    v.VilenjakZaPokloneVestinaSpoj.Add(spojEntitet);
                }
            }
            catch (Exception ex) 
            { 
            throw;
            }
        }


        public static IList<TovarView> vratiSveTovare()
        {
            ISession s = null;
            IList<TovarView> views = new List<TovarView>();
            try
            {
                s = DataLayer.GetSession();
                var tovari = s.Query<Tovar>().ToList();
                foreach(var tovar in tovari)
                {
                    var view = new TovarView();
                    view.ID = tovar.ID;
                    view.Grad = tovar.Grad;
                    
                    foreach(var poklon in tovar.Pokloni)
                    {
                        var poklonView = new PoklonView(poklon);
                        view.Pokloni.Add(poklonView);
                    }
                    foreach(var vilenjak in tovar.Vilenjaci)
                    {
                        var vilenjakView = new VilenjakZaIsporukuPoklonaView(vilenjak);
                        view.Vilenjaci.Add(vilenjakView);
                    }
                    foreach(var irvas in tovar.IrvasIsporucujeTovar)
                    {
                        var IrvasIsporucujeTovarView = new IrvasIsporucujeTovarView(irvas);
                        view.IrvasIsporucujeTovar.Add(IrvasIsporucujeTovarView);
                    }
                    views.Add(view);
                }   
            }
            catch (Exception ex) { }
            finally { s?.Close(); }
            return views;
        }


        public static Tovar dodajTovar(TovarView view)
        {
            ISession s = null;
            Tovar tovar = null;
            try
            {
                s = DataLayer.GetSession();
                tovar = new Tovar();
                tovar.Grad = view.Grad;
                foreach(var poklon in view.Pokloni)
                {
                    var poklonEntitet = new Poklon();
                    poklonEntitet.ID = poklon.ID;
                    poklonEntitet.PripadaTovaru = tovar;
                    poklonEntitet.Boja = poklon.Boja;
                    poklonEntitet.Posveta = poklon.Posveta;
                    poklonEntitet.ZaListuZelja = new ListaZelja();
                    poklonEntitet.ZaListuZelja.ID = poklon.ZaListuZelja.ID;
                    tovar.Pokloni.Add(poklonEntitet);
                }
                foreach(var vilenjak in view.Vilenjaci)
                {
                    var vilenjakEntitet = new VilenjakZaIsporukuPoklona();
                    vilenjakEntitet.ID = vilenjak.ID;
                    vilenjakEntitet.ZemljaPorekla = vilenjak.ZemljaPorekla;
                    vilenjakEntitet.DatumZaposlenja = vilenjak.DatumZaposlenja;
                    vilenjakEntitet.JedinstvenoIme = vilenjak.JedinstvenoIme;
                    vilenjakEntitet.VilenjakZaIsporukuVestinaSpoj = new List<SpojVilenjakZaIsporukuVestina>();
                    foreach(var spoj in vilenjak.VilenjakZaIsporukuVestinaSpoj)
                    {
                        var spojEntitet = new SpojVilenjakZaIsporukuVestina();
                        spojEntitet.ID = spoj.ID;
                        spojEntitet.MagicnaVestina = new MagicnaVestina();
                        spojEntitet.MagicnaVestina.ID = spoj.MagicnaVestina.ID;
                        spojEntitet.VilenjakZaIsporukuPoklona = vilenjakEntitet;
                        vilenjakEntitet.VilenjakZaIsporukuVestinaSpoj.Add(spojEntitet);
                    }
                    vilenjakEntitet.Tovar = tovar;
                    tovar.Vilenjaci.Add(vilenjakEntitet);
                }
                foreach(var irvas in view.IrvasIsporucujeTovar)
                {
                    var irvasEntitet = new IrvasIsporucujeTovar();
                    irvasEntitet.ID = irvas.ID;
                    irvasEntitet.Tovar = tovar;
                    irvasEntitet.Irvas = new Irvas();
                    irvasEntitet.Irvas.ID = irvas.Irvas.ID;
                    tovar.IrvasIsporucujeTovar.Add(irvasEntitet);
                }
                s.Save(tovar);
                s.Flush();
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return tovar;
        }

        public static Tovar azurirajTovar(TovarView view)
        {
            ISession s = null;
            Tovar tovar = null;
            try
            {
                s = DataLayer.GetSession();
                tovar = s.Get<Tovar>(view.ID);
                tovar.Grad = view.Grad;
                foreach (var poklon in view.Pokloni)
                {
                    var poklonEntitet = new Poklon();
                    poklonEntitet.ID = poklon.ID;
                    poklonEntitet.PripadaTovaru = tovar;
                    poklonEntitet.Boja = poklon.Boja;
                    poklonEntitet.Posveta = poklon.Posveta;
                    poklonEntitet.ZaListuZelja = new ListaZelja();
                    poklonEntitet.ZaListuZelja.ID = poklon.ZaListuZelja.ID;
                    tovar.Pokloni.Add(poklonEntitet);
                }
                foreach(var isporuka in tovar.IrvasIsporucujeTovar)
                {
                    var irvasIsporucujeTovar = new IrvasIsporucujeTovar();
                    irvasIsporucujeTovar.ID = isporuka.ID;
                    irvasIsporucujeTovar.Tovar = tovar;
                    irvasIsporucujeTovar.Irvas = new Irvas();
                    irvasIsporucujeTovar.Irvas.ID = isporuka.Irvas.ID;
                    tovar.IrvasIsporucujeTovar.Add(irvasIsporucujeTovar);
                }
                foreach(var vilenjak in tovar.Vilenjaci)
                {
                    var v = new VilenjakZaIsporukuPoklona();
                    v.ID = vilenjak.ID;
                    v.ZemljaPorekla = vilenjak.ZemljaPorekla;
                    v.DatumZaposlenja = vilenjak.DatumZaposlenja;
                    v.JedinstvenoIme = vilenjak.JedinstvenoIme;
                    v.VilenjakZaIsporukuVestinaSpoj = new List<SpojVilenjakZaIsporukuVestina>();
                    foreach(var spoj in vilenjak.VilenjakZaIsporukuVestinaSpoj)
                    {
                        var spojEntitet = new SpojVilenjakZaIsporukuVestina();
                        spojEntitet.ID = spoj.ID;
                        spojEntitet.MagicnaVestina = new MagicnaVestina();
                        spojEntitet.MagicnaVestina.ID = spoj.MagicnaVestina.ID;
                        spojEntitet.VilenjakZaIsporukuPoklona = v;
                        v.VilenjakZaIsporukuVestinaSpoj.Add(spojEntitet);
                    }
                    v.Tovar = tovar;
                    tovar.Vilenjaci.Add(v);
                }
                s.SaveOrUpdate(tovar);
                s.Flush();
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return tovar;
        }


        public static bool obrisiTovar(int id)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                var tovar = s.Get<Tovar>(id);
                s.Delete(tovar);
                s.Flush();
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return true;
        }


        public static IList<TimView> vratiSveTimove()
        {
            ISession s = null;
            IList<TimView> views = new List<TimView>();
            try
            {
                s = DataLayer.GetSession();
                var timovi = s.Query<Tim>().ToList();
                foreach(var tim in timovi)
                {
                    var view = new TimView(tim);
                    foreach(var vilenjak in tim.Vilejnaci)
                    {
                        var vilenjakView = new VilenjakZaIzraduIgracakaView(vilenjak);
                        view.Vilenjaci.Add(vilenjakView);
                    }
                    views.Add(view);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return views;
        }

        public static Tim dodajTim(TimView view)
        {
            ISession s = null;
            Tim t = null;
            try
            {
                s = DataLayer.GetSession();
                t = new Tim();
                t.ID = view.ID;
                t.Naziv = view.Naziv;
                t.Vilejnaci = new List<VilenjakZaIzraduIgracaka>();
                foreach (var elf in view.Vilenjaci)
                {
                    var vilenjak = new VilenjakZaIzraduIgracaka();
                    vilenjak.ID = elf.ID;
                    vilenjak.JedinstvenoIme = elf.JedinstvenoIme;
                    vilenjak.DatumZaposlenja = elf.DatumZaposlenja;
                    vilenjak.ZemljaPorekla = elf.ZemljaPorekla;
                    vilenjak.PripadaTimu = t;
                    vilenjak.VilenjakZaIgrackeVestinaSpoj = new List<SpojVilenjakZaIgrackeVestina>();
                    foreach (var spoj in elf.VilenjakZaIgrackeVestinaSpoj)
                    {
                        var spojEntitet = new SpojVilenjakZaIgrackeVestina();
                        spojEntitet.ID = spoj.ID;
                        spojEntitet.MagicnaVestina = new MagicnaVestina();
                        spojEntitet.MagicnaVestina.ID = spoj.MagicnaVestina.ID;
                        spojEntitet.VilenjakZaIzraduIgracaka = vilenjak;
                        vilenjak.VilenjakZaIgrackeVestinaSpoj.Add(spojEntitet);
                    }
                    t.Vilejnaci.Add(vilenjak);
                }
                s.SaveOrUpdate(t);
                s.Flush();
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return t;
        }

        public static Tim azurirajTim(TimView view)
        {
            ISession s = null;
            Tim t = null;
            try
            {
                s = DataLayer.GetSession();
                t = s.Get<Tim>(view.ID);
                t.Naziv = view.Naziv;
                t.Vilejnaci = new List<VilenjakZaIzraduIgracaka>();
                foreach (var elf in view.Vilenjaci)
                {
                    var vilenjak = new VilenjakZaIzraduIgracaka();
                    vilenjak.ID = elf.ID;
                    vilenjak.JedinstvenoIme = elf.JedinstvenoIme;
                    vilenjak.DatumZaposlenja = elf.DatumZaposlenja;
                    vilenjak.ZemljaPorekla = elf.ZemljaPorekla;
                    vilenjak.PripadaTimu = t;
                    vilenjak.VilenjakZaIgrackeVestinaSpoj = new List<SpojVilenjakZaIgrackeVestina>();
                    foreach (var spoj in elf.VilenjakZaIgrackeVestinaSpoj)
                    {
                        var spojEntitet = new SpojVilenjakZaIgrackeVestina();
                        spojEntitet.ID = spoj.ID;
                        spojEntitet.MagicnaVestina = new MagicnaVestina();
                        spojEntitet.MagicnaVestina.ID = spoj.MagicnaVestina.ID;
                        spojEntitet.VilenjakZaIzraduIgracaka = vilenjak;
                        vilenjak.VilenjakZaIgrackeVestinaSpoj.Add(spojEntitet);
                    }
                    t.Vilejnaci.Add(vilenjak);
                }
                s.SaveOrUpdate(t);
                s.Flush();

            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return t;
        }

        public static bool obrisiTim(int id)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                var tim = s.Get<Tim>(id);
                s.Delete(tim);
                s.Flush();
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return true;
        }


        public static List<PesmaView> vratiSvePesme()
        {
            ISession s = null;
            List<PesmaView> views = new List<PesmaView>();
            try
            {
                s = DataLayer.GetSession();
                var pesme = s.Query<Pesma>().ToList();
                foreach(var pesma in pesme)
                {
                    var view = new PesmaView(pesma);
                    view.VilenjakZaIrvase = new VilenjakZaIrvaseView(pesma.VilenjakZaIrvase);
                    views.Add(view);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return views;
        }

        public static Pesma dodajPesmu(PesmaView view)
        {
            ISession s = null;
            Pesma p = null;
            try
            {
                s = DataLayer.GetSession();
                p = new Pesma();
                p.ID = view.ID;
                p.Naziv = view.Naziv;
                p.Tekst = view.Tekst;
                p.VilenjakZaIrvase = new VilenjakZaIrvase();
                p.VilenjakZaIrvase.ID = view.VilenjakZaIrvase.ID;
                p.VilenjakZaIrvase.JedinstvenoIme = view.VilenjakZaIrvase.JedinstvenoIme;
                p.VilenjakZaIrvase.DatumZaposlenja = view.VilenjakZaIrvase.DatumZaposlenja;
                p.VilenjakZaIrvase.ZemljaPorekla = view.VilenjakZaIrvase.ZemljaPorekla;
                p.VilenjakZaIrvase.Pesme.Add(p);
                s.SaveOrUpdate(p);
                s.Flush();
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return p;
        }

        public static Pesma azurirajPesmu(PesmaView view)
        {
            ISession s = null;
            Pesma pesma = null;
            try
            {
                s = DataLayer.GetSession();
                pesma = s.Get<Pesma>(view.ID);
                pesma.Naziv = view.Naziv;
                pesma.Tekst = view.Tekst;
                pesma.VilenjakZaIrvase = new VilenjakZaIrvase();
                pesma.VilenjakZaIrvase.ID = view.VilenjakZaIrvase.ID;
                pesma.VilenjakZaIrvase.JedinstvenoIme = view.VilenjakZaIrvase.JedinstvenoIme;
                pesma.VilenjakZaIrvase.DatumZaposlenja = view.VilenjakZaIrvase.DatumZaposlenja;
                pesma.VilenjakZaIrvase.ZemljaPorekla = view.VilenjakZaIrvase.ZemljaPorekla;
                s.SaveOrUpdate(pesma);
                s.Flush();
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return pesma;
        }


        public static bool obrisiPesmu(int id)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                var pesma = s.Get<Pesma>(id);
                s.Delete(pesma);
                s.Flush();
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return true;
        }

        public static List<PoklonView> VratiSvePoklone()
        {
            ISession s = null;
            List<PoklonView> views = new List<PoklonView>();
            try
            {
                s = DataLayer.GetSession();
                var pokloni = s.Query<Poklon>().ToList();
                foreach (var poklon in pokloni)
                {
                    var view = new PoklonView(poklon);

                    foreach (var igracka in poklon.IgrackeZaPoklon)
                    {
                        var igrackaView = new IgrackaView(igracka);
                        view.IgrackeZaPoklon.Add(igrackaView);
                    }
                    foreach (var pakovanje in poklon.PakovanjePoklona)
                    {
                        var pakovanjeView = new PakovanjePoklonaView(pakovanje);
                        view.PakovanjePoklona.Add(pakovanjeView);
                    }
                    views.Add(view);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return views;
        }


        public static Poklon DodajPoklon(PoklonView view)
        {
            ISession s = null;
            Poklon p = null;
            try
            {
                s = DataLayer.GetSession();
                p = new Poklon();
                p.ID = view.ID;
                p.Boja = view.Boja;
                p.Posveta = view.Posveta;
                p.PripadaTovaru = new Tovar();
                p.PripadaTovaru.ID = view.PripadaTovaru.ID;
                p.ZaListuZelja = new ListaZelja();
                p.ZaListuZelja.ID = view.ZaListuZelja.ID;
                p.IgrackeZaPoklon = new List<Igracka>();
                p.PakovanjePoklona = new List<PakovanjePoklona>();
                foreach(var igracka in view.IgrackeZaPoklon)
                {
                    var igrackaEntitet = new Igracka();
                    igrackaEntitet.ID = igracka.ID;
                    igrackaEntitet.Tip = igracka.Tip;
                    igrackaEntitet.Opis = igracka.Opis;
                    p.IgrackeZaPoklon.Add(igrackaEntitet);
                }
                foreach (var pakovanje in view.PakovanjePoklona)
                {
                    var pakovanjeEntitet = new PakovanjePoklona();
                    pakovanjeEntitet.ID = pakovanje.ID;
                    p.PakovanjePoklona.Add(pakovanjeEntitet);
                }
                s.SaveOrUpdate(p);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return p;
        }

        public static Poklon AzurirajPoklon(PoklonView view)
        {
            ISession s = null;
            Poklon p = null;
            try
            {
                s = DataLayer.GetSession();
                p = s.Get<Poklon>(view.ID);
                p.Boja = view.Boja;
                p.Posveta = view.Posveta;
                p.PripadaTovaru = new Tovar();
                p.PripadaTovaru.ID = view.PripadaTovaru.ID;
                p.ZaListuZelja = new ListaZelja();
                p.ZaListuZelja.ID = view.ZaListuZelja.ID;
                p.IgrackeZaPoklon = new List<Igracka>();
                p.PakovanjePoklona = new List<PakovanjePoklona>();
                foreach (var igracka in view.IgrackeZaPoklon)
                {
                    var igrackaEntitet = new Igracka();
                    igrackaEntitet.ID = igracka.ID;
                    igrackaEntitet.Tip = igracka.Tip;
                    igrackaEntitet.Opis = igracka.Opis;
                    p.IgrackeZaPoklon.Add(igrackaEntitet);
                }
                foreach (var pakovanje in view.PakovanjePoklona)
                {
                    var pakovanjeEntitet = new PakovanjePoklona();
                    pakovanjeEntitet.ID = pakovanje.ID;
                    p.PakovanjePoklona.Add(pakovanjeEntitet);
                }
                s.SaveOrUpdate(p);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return p;
        }


        public static bool ObrisiPoklon(int id)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                var p = s.Load<Poklon>(id);
                s.Delete(p);
                s.Flush();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { s?.Close(); }
            return true;
        }



        public static VilenjakZaIzraduIgracaka IzmeniVilenjakaZaIzraduIgracaka(VilenjakZaIzraduIgracakaView view)
        {
            ISession s = null;
            VilenjakZaIzraduIgracaka v = null;
            try
            {
                s = DataLayer.GetSession();
                v = s.Get<VilenjakZaIzraduIgracaka>(view.ID);
                v.JedinstvenoIme = view.JedinstvenoIme;
                v.ZemljaPorekla = view.ZemljaPorekla;
                v.DatumPostavljanja = view.DatumPostavljanja;
                v.DatumZaposlenja = view.DatumZaposlenja;
                v.FlagSef = view.FlagSef;
                v.FlagKoordinator = view.FlagKoordinator;
                v.DeoRadionice = s.Get<DeoRadionice>(view.DeoRadionice.ID);
                v.DuzinaObuke = view.DuzinaObuke;
                v.Ocena = view.Ocena;
                v.ImaMentora = s.Get<VilenjakZaIzraduIgracaka>(view.ImaMentora);
                v.PripadaTimu = s.Get<Tim>(view.PripadaTimu.ID);
                v.TipMaterijala = view.TipMaterijala;
                v.Igracke = new List<Igracka>();
                v.JeMentor = new List<VilenjakZaIzraduIgracaka>();
                v.VilenjakZaIgrackeVestinaSpoj = new List<SpojVilenjakZaIgrackeVestina>();
                foreach(var igracka in view.Igracke)
                {
                    v.Igracke.Add(s.Get<Igracka>(igracka.ID));
                }
                foreach(var vilenjak in view.JeMentor)
                {
                    v.JeMentor.Add(s.Get<VilenjakZaIzraduIgracaka>(vilenjak.ID));
                }
                foreach(var spoj in view.VilenjakZaIgrackeVestinaSpoj)
                {
                    v.VilenjakZaIgrackeVestinaSpoj.Add(s.Get<SpojVilenjakZaIgrackeVestina>(spoj.ID));
                }
                s.SaveOrUpdate(v);
                s.Flush();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                s?.Close();
            }
            return v;
        }
    }

}

