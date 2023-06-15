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
using System.Security.Cryptography.X509Certificates;
using OracleInternal.SqlAndPlsqlParser.LocalParsing;

namespace DatabaseAccess
{
    public class DataProvider
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
            catch (Exception ex)
            {// MessageBox.Show(ex.Message);
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

        public static bool dodajVilenjakaZaIgracke(VilenjakZaIzraduIgracaka form)
        {
            ISession s = null;
            VilenjakZaIzraduIgracaka vie = new VilenjakZaIzraduIgracaka();
            try
            {
                s = DataLayer.GetSession();
                s.SaveOrUpdate(form);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                s?.Flush(); s?.Close();
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
        public static VilenjakBasic vratiVilenjakaSaVestinama(string ime)
        {
            VilenjakBasic vilenjak = null;

            vilenjak = vratiVilenjakaZaIrvaseSaVestinama(ime);
            //MessageBox.Show("1");
            if (vilenjak != null)
                return vilenjak;
            vilenjak = vratiVilenjakaZaIzraduIgracakaSaVestinama(ime);
            //MessageBox.Show("2");
            if (vilenjak != null)
                return vilenjak;
            vilenjak = vratiVilenjakaZaPokloneSaVestinama(ime);
            //MessageBox.Show("3");
            if (vilenjak != null)
                return vilenjak;
            vilenjak = vratiVilenjakaZaIsporukuPoklonaSaVestinama(ime);
            //MessageBox.Show("4");
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
            finally { s?.Flush(); s?.Close(); }
            return vilenjak;
        }

        public static VilenjakZaIzraduIgracakaSaVestinama vratiVilenjakaZaIzraduIgracakaSaVestinama(string ime)
        {
            ISession s = null;
            VilenjakZaIzraduIgracakaSaVestinama vilenjakDTO = null;
            IList<MagicnaVestinaPrikaz> vestine = null;
            try
            {
                s = DataLayer.GetSession();

                var vilenjak = s.Query<VilenjakZaIzraduIgracaka>()
                    .Where(v => v.JedinstvenoIme.Equals(ime))
                    .ToList().FirstOrDefault();
                if (!vilenjak.VilenjakZaIgrackeVestinaSpoj.IsEmpty())
                {
                    var vestineSpojevi = vilenjak.VilenjakZaIgrackeVestinaSpoj;
                    vestine = new List<MagicnaVestinaPrikaz>();
                    foreach (var item in vestineSpojevi)
                    {
                        vestine.Add(new MagicnaVestinaPrikaz(item.MagicnaVestina.Naziv, item.MagicnaVestina.ID));
                    }
                }
                else
                {
                    vestine = new List<MagicnaVestinaPrikaz>();
                }


                if (vilenjak.ImaMentora == null)
                {
                    vilenjak.ImaMentora = new VilenjakZaIzraduIgracaka();
                    vilenjak.ImaMentora.ID = 0;
                    vilenjak.ImaMentora.JedinstvenoIme = String.Empty;
                    vilenjak.ImaMentora.ZemljaPorekla = String.Empty;
                    vilenjak.ImaMentora.DatumZaposlenja = DateTime.MinValue;
                }

                vilenjakDTO = new VilenjakZaIzraduIgracakaSaVestinama
                    (vilenjak.ID, vilenjak.JedinstvenoIme,
                    vilenjak.ZemljaPorekla,
                    vilenjak.DatumZaposlenja, vilenjak.TipMaterijala,
                    new DeoRadioniceID(vilenjak.DeoRadionice.ID, vilenjak.DeoRadionice.Naziv), vilenjak.FlagSef,
                    new TimID(vilenjak.PripadaTimu.ID, vilenjak.PripadaTimu.Naziv), vilenjak.FlagKoordinator, vilenjak.DuzinaObuke, vilenjak.Ocena,
                    new VilenjakZaIzraduIgracakaMentor(vilenjak.ImaMentora.ID, vilenjak.ImaMentora.JedinstvenoIme, vilenjak.ImaMentora.ZemljaPorekla, vilenjak.ImaMentora.DatumZaposlenja),
                    vestine
                    );

            }
            catch (Exception ex)
            {
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

        public static VilenjakZaIrvaseSaVestinama vratiVilenjakaZaIrvaseSaVestinama(string ime)
        {
            ISession s = null;
            VilenjakZaIrvase vilenjak = null;
            VilenjakZaIrvaseSaVestinama v = null;
            try
            {
                s = DataLayer.GetSession();
                vilenjak = s.Query<VilenjakZaIrvase>().Where(elv => elv.JedinstvenoIme.Equals(ime)).ToList().FirstOrDefault();
                IList<MagicnaVestinaPrikaz> vestine;
                if (!vilenjak.VilenjakZaIrvaseVestinaSpoj.IsEmpty())
                {
                    var vestineSpojevi = vilenjak.VilenjakZaIrvaseVestinaSpoj;
                    vestine = new List<MagicnaVestinaPrikaz>();
                    foreach (var item in vestineSpojevi)
                    {
                        vestine.Add(new MagicnaVestinaPrikaz(item.MagicnaVestina.Naziv, item.MagicnaVestina.ID));
                    }
                }
                else
                {
                    vestine = new List<MagicnaVestinaPrikaz>();
                }
                v = new VilenjakZaIrvaseSaVestinama
                        (vilenjak.ID, vilenjak.JedinstvenoIme,
                        vilenjak.ZemljaPorekla, vilenjak.DatumZaposlenja,
                        vestine, new IrvasDTO(vilenjak.Irvas.ID, vilenjak.Irvas.Ime, vilenjak.Irvas.Nadimak, vilenjak.Irvas.Pol, vilenjak.Irvas.Starost));
            }
            catch (Exception ex)
            {

            }
            finally
            {

                s?.Close();
            }
            return v;
        }

        public static VilenjakZaIsporukuPoklonaSaVestinama vratiVilenjakaZaIsporukuPoklonaSaVestinama(string ime)
        {
            ISession s = null;
            VilenjakZaIsporukuPoklona vilenjak = null;
            IList<MagicnaVestinaPrikaz> vestine = null;
            VilenjakZaIsporukuPoklonaSaVestinama ret = null;
            try
            {
                s = DataLayer.GetSession();

                vilenjak = s.Query<VilenjakZaIsporukuPoklona>()
                    .Where(v => v.JedinstvenoIme.Equals(ime))
                    .ToList().First();
                if (!vilenjak.VilenjakZaIsporukuVestinaSpoj.IsEmpty())
                {
                    var vestineSpojevi = vilenjak.VilenjakZaIsporukuVestinaSpoj;
                    vestine = new List<MagicnaVestinaPrikaz>();
                    foreach (var item in vestineSpojevi)
                    {
                        vestine.Add(new MagicnaVestinaPrikaz(item.MagicnaVestina.Naziv, item.MagicnaVestina.ID));
                    }
                }
                else
                {
                    vestine = new List<MagicnaVestinaPrikaz>();
                }

                ret = new VilenjakZaIsporukuPoklonaSaVestinama(vilenjak.ID, vilenjak.JedinstvenoIme, vilenjak.ZemljaPorekla, vilenjak.DatumZaposlenja, new TovarBasic(vilenjak.Tovar.Grad));
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                s?.Close();
            }
            return ret;
        }

        public static VilenjakZaPokloneSaVestinama vratiVilenjakaZaPokloneSaVestinama(string ime)
        {
            ISession s = null;
            VilenjakZaPoklone vilenjak = null;
            IList<MagicnaVestinaPrikaz> vestine = null;
            VilenjakZaPokloneSaVestinama v = null;
            try
            {
                s = DataLayer.GetSession();

                vilenjak = s.Query<VilenjakZaPoklone>()
                    .Where(elf => elf.JedinstvenoIme.Equals(ime))
                    .ToList().First();

                if (!vilenjak.VilenjakZaPokloneVestinaSpoj.IsEmpty())
                {
                    var vestineSpojevi = vilenjak.VilenjakZaPokloneVestinaSpoj;
                    vestine = new List<MagicnaVestinaPrikaz>();
                    foreach (var item in vestineSpojevi)
                    {
                        vestine.Add(new MagicnaVestinaPrikaz(item.MagicnaVestina.Naziv, item.MagicnaVestina.ID));
                    }
                }
                else
                {
                    vestine = new List<MagicnaVestinaPrikaz>();
                }

                IList<PoklonBasic> poklonBasics = new List<PoklonBasic>();
                foreach (var item in vilenjak.PakovanjePoklona)
                {
                    var poklon = s.Query<Poklon>().Where(p => p.ID == item.Poklon.ID).FirstOrDefault();
                    var lz = s.Query<ListaZelja>().Where(l => l.ID == poklon.ZaListuZelja.ID).FirstOrDefault();
                    var pismo = s.Query<Pismo>().Where(p => p.ID == lz.ID).FirstOrDefault();
                    var dete = s.Query<Dete>().Where(d => d.ID == pismo.PripadaDetetu.ID).FirstOrDefault();
                    var grad = item.Poklon.PripadaTovaru.Grad;
                    poklonBasics.Add(new PoklonBasic(poklon.ID, poklon.Boja, poklon.Posveta, poklon.ZaListuZelja, poklon.PripadaTovaru, grad, dete.Ime));
                }
                v = new VilenjakZaPokloneSaVestinama(vilenjak.ID, vilenjak.JedinstvenoIme, vilenjak.ZemljaPorekla, vilenjak.DatumZaposlenja, poklonBasics, vestine);
            }
            catch (Exception ex)
            {
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

        public static IList<PismoView> vratiSvaPisma()
        {
            IList<PismoView> pisma = new List<PismoView>();
            IList<ListaZeljaView> listaZelja = new List<ListaZeljaView>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                pisma = s.Query<Pismo>()
                .Select(pismo => new PismoView(pismo))
                .ToList();

                listaZelja = s.Query<ListaZelja>()
                          .Select(x => new ListaZeljaView(x))
                          .ToList();

                foreach (var pismo in pisma)
                {
                    var pripadajucaListaZelja = listaZelja.FirstOrDefault(l => l.PripadaPismu.ID == pismo.ID);
                    if (pripadajucaListaZelja != null)
                    {
                        pismo.ListaZelja = pripadajucaListaZelja;
                    }
                }

                s?.Flush();
            }
            catch (Exception e)
            {
                throw;
            }
            finally { s?.Close(); }
            return pisma;
        }

        public static IList<DeteView> vratiSvuDecu()
        {
            IList<DeteView> deca = new List<DeteView>();
            IList<PismoView> pisma = new List<PismoView>();
            IList<DeteRoditeljView> deteRoditelj = new List<DeteRoditeljView>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                deca = s.Query<Dete>()
                .Select(d => new DeteView(d))
                .ToList();

                pisma = s.Query<Pismo>().Select(x => new PismoView(x)).ToList();

                deteRoditelj = s.Query<DeteRoditelj>().Select(x => new DeteRoditeljView(x)).ToList();

                foreach (var d in deca)
                {
                    foreach (var p in pisma)
                    {
                        if (p.PripadaDetetu.ID == d.ID)
                            d.Pisma.Add(p);
                    }
                    foreach (var dr in deteRoditelj)
                    {
                        if (dr.Dete.ID == d.ID)
                            d.Roditelji.Add(dr);
                    }
                }


            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
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
        public static bool dodajListuZelja(ListaZeljaView lz)
        {
            ISession s = null;
            ListaZelja listazelja = new ListaZelja();
            try
            {
                s = DataLayer.GetSession();

                var pismo = s.Query<Pismo>().Where(d => d.ID == lz.PripadaPismu.ID).FirstOrDefault();
             
                if (pismo != null) throw new Exception("Dodaj novo pismo.");
              
                if (pismo.ListaZelja == null)
                {

                    listazelja.PripadaPismu = pismo;
                }
                else throw new Exception("Morate dodati novo pismo. Lista zelja je vezana za samo jedno pismo.");

             
                else throw new Exception("Dodajte poklon. Poklon je vezan za jednu listu zelja");
                s.SaveOrUpdate(listazelja);
                lz.ID = listazelja.ID;
                
            }
            catch (Exception ex)
            {
                throw;
                return false;
            }
            finally { s?.Close(); }
            return true;
        }

        public static IList<ListaZeljaView> vratiListeZelja()
        {
            IList<ListaZeljaView> liste = new List<ListaZeljaView>();
            IList<PoklonView> pokloni = new List<PoklonView>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                liste = s.Query<ListaZelja>()
                    .Select(l => new ListaZeljaView(l))
                    .ToList();

                pokloni = s.Query<Poklon>().Select(x => new PoklonView(x)).ToList();
                foreach(var lista in liste)
                {
                    foreach(var poklon in pokloni)
                    {
                        if (lista.Poklon.ID == poklon.ID)
                            lista.Poklon = poklon;
                    }
                }

            }
            catch (Exception e)
            {
                throw;
            }
            finally { s?.Flush(); s?.Close(); }
            return liste;
        }

        public static IList<DeteRoditeljView> vratiRoditelje()
        {
            IList<DeteRoditeljView> roditelji = new List<DeteRoditeljView>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                roditelji = s.Query<DeteRoditelj>().Select(x => new DeteRoditeljView()).ToList();


            }
            catch (Exception ex)
            {
                throw;
            }
            finally { s?.Flush(); ; s?.Close(); }
            return roditelji;
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
        public static Igracka dodajIgracka(IgrackaView igr)
        {
            ISession s = null;
            Igracka igracka = new Igracka();
            try
            {
                s = DataLayer.GetSession();

                var poklon = s.Query<Poklon>().Where(d => d.ID == igr.PripadaPoklonu.ID).FirstOrDefault();
                var deoRadionice = s.Query<DeoRadionice>().Where(d => d.ID == igr.IzradjenaUDeluRadionice.ID).FirstOrDefault();
                var listaZelja = s.Query<ListaZelja>().Where(x => x.ID == igr.PripadaListiZelja.ID).FirstOrDefault();
                var vilenjak = s.Query<VilenjakZaIzraduIgracaka>().Where(x => x.ID == igr.Vilenjak.ID).FirstOrDefault();

                if (poklon == null) throw new Exception("Nema ovog poklona za datu igracku u bazi");
                if (deoRadionice == null) throw new Exception("Nema ovog dela radionice u bazi");
                if (listaZelja == null) throw new Exception("Nema ove liste zelja ju bazi");
                if (vilenjak == null) throw new Exception("Nema trazenog vilenjaka u bazi");

                igracka.RedniBroj = igr.RedniBroj;
                igracka.Tip = igr.Tip;
                igracka.Opis = igr.Opis;
                igracka.PripadaPoklonu = poklon;
                igracka.IzradjenaUDeluRadionice = deoRadionice;
                igracka.PripadaListiZelja = listaZelja;
                igracka.Vilenjak = vilenjak;

                s.SaveOrUpdate(igracka);
                igr.ID = igracka.ID;
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
                if (pismo == null)
                {
                    throw new Exception("Ne postoji pismo sa zadatim ID-jem");
                }

                var zelje = s.Query<ListaZelja>().Where(z => z.PripadaPismu.ID == id).ToList();

                foreach (var zelja in zelje)
                {
                    var poklon = s.Query<Poklon>().Where(x => x.ZaListuZelja.ID == zelja.ID).ToList();
                    foreach (var p in poklon)
                    {

                        s.Delete(p);
                    }
                    s.Delete(zelja);
                }

                s.Delete(pismo);


            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }


        public static bool dodajDete(DeteView dete)
        {
            ISession s = null;
            Dete d = new Dete();

            try
            {
                s = DataLayer.GetSession();

                d.Ime = dete.Ime;
                d.Prezime = dete.Prezime;
                d.Adresa = d.Adresa;
                d.Grad = dete.Grad;
                d.Drzava = dete.Drzava;
                d.DatumRodjenja = dete.DatumRodjenja;


                s.SaveOrUpdate(d);
                dete.ID = d.ID;
                s?.Flush();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { s?.Close(); }
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

                if (dete == null)
                {
                    throw new Exception("Dete ne postoji! Morate uneti prvo dete koje je napisalo ovo pismo.");
                }

                p.Tekst = pismo.Tekst;
                p.IndeksDobrote = pismo.IndeksDobrote;
                p.DatumSlanja = pismo.DatumSlanja;
                p.DatumPrijema = pismo.DatumPrijema;
                p.PripadaDetetu = dete;


                s.SaveOrUpdate(p);
                pismo.ID = p.ID;
                s?.Flush();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { s?.Close(); }
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
                foreach (var vilenjak in vilenjaci)
                {
                    vilenjak.DeoRadionice = nerasporedjen;
                }
                var magicnaVestina = s.Query<MagicnaVestina>().Where(mv => mv.PotrebnaDeluRadionice.ID == radionica.ID).ToList();
                foreach (var mv in magicnaVestina)
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
            catch (Exception ex)
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

        public static bool dodajIrvasa(IrvasView i)
        {
            ISession s = null;
            Irvas irvas = new Irvas();
            try
            {
                s = DataLayer.GetSession();

                irvas.Ime = i.Ime;
                irvas.Nadimak = i.Nadimak;
                irvas.Pol = i.Pol;
                irvas.DatumRodjenja = i.DatumRodjenja;
                irvas.Starost = i.Starost;

                s.SaveOrUpdate(irvas);
                i.ID = irvas.ID;
            }

            catch (Exception e)
            {
                throw;
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
                    s.Delete(vilenjak);
                }
                var irvasTovar = s.Query<IrvasIsporucujeTovar>().Where(i=> i.Irvas.ID ==irvas.ID).ToList();
                foreach(var i in irvasTovar)
                {
                    s.Delete(i);
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

        public static IList<IrvasView> vratiSveIrvase()
        {
            IList<IrvasView> irvasi = new List<IrvasView>();
            IList<VilenjakZaIrvaseView> vilenjaci = new List<VilenjakZaIrvaseView>();
            IList<IrvasIsporucujeTovarView> irvasiTovar = new List<IrvasIsporucujeTovarView>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                irvasi = s.Query<Irvas>()
                    .Select(r => new IrvasView(r))
                    .ToList();

                vilenjaci = s.Query<VilenjakZaIrvase>().Select(x => new VilenjakZaIrvaseView(x)).ToList();
                irvasiTovar = s.Query<IrvasIsporucujeTovar>().Select(x => new IrvasIsporucujeTovarView(x)).ToList();

                foreach (var irvas in irvasi)
                {
                    foreach(var vilenjak in vilenjaci)
                    {
                        if (vilenjak.Irvas.ID == irvas.ID)
                            irvas.Vilenjaci.Add(vilenjak);
                    }

                    foreach(var i in irvasiTovar)
                    {
                        if (i.Irvas.ID == irvas.ID)
                            irvas.IrvasIsporucujeTovar.Add(i);
                    }
                }


            }
            catch (Exception ex) { }
            finally { s?.Close(); }
            return irvasi;
        }

        public static bool azurirajIrvasa(IrvasView irvas)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                Irvas i = s.Load<Irvas>(irvas.ID);

                i.Ime = irvas.Ime;
                i.Nadimak = irvas.Nadimak;
                i.Pol = irvas.Pol;
                i.DatumRodjenja = irvas.DatumRodjenja;

                s.SaveOrUpdate(i);
            }
            catch (Exception ex) { return false; }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        //nova za azuriraj pismo
        public static bool azurirajPismo(PismoView pismo)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                Pismo p = s.Load<Pismo>(pismo.ID);

                p.IndeksDobrote = pismo.IndeksDobrote;
                p.Tekst = pismo.Tekst;
                p.DatumSlanja = pismo.DatumSlanja;
                p.DatumPrijema = pismo.DatumPrijema;

                s.SaveOrUpdate(p);
            }
            catch (Exception ex)
            {
                return false;

            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static bool azurirajDete(DeteView dete)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                Dete p = s.Load<Dete>(dete.ID);

                p.Ime = dete.Ime;
                p.Prezime = dete.Prezime;
                p.Grad = dete.Grad;
                p.Adresa = dete.Adresa;
                p.Drzava = dete.Drzava;

                s.SaveOrUpdate(p);
            }
            catch (Exception ex)
            {
                return false;

            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static bool obrisiDete(int id)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                Dete dete = s.Get<Dete>(id);
                if (dete == null)
                {
                    throw new Exception("Ne postoji dete sa zadatim ID-jem");
                }

                var pisma = s.Query<Pismo>().Where(z => z.PripadaDetetu.ID == id).ToList();

                foreach (var pismo in pisma)
                {
                    var zelja = s.Query<ListaZelja>().FirstOrDefault(x => x.PripadaPismu.ID == pismo.ID);
                    if (zelja != null) s.Delete(zelja);
                    s.Delete(pismo);
                }

                s.Delete(dete);


            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static IList<IgrackaView> vratiSveIgracke()
        {
            IList<IgrackaView> igracke = new List<IgrackaView>();
            IList<PoklonView> pokloni = new List<PoklonView>();
            IList<DeoRadioniceView> dRad = new List<DeoRadioniceView>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                igracke = s.Query<Igracka>()
                    .Select(r => new IgrackaView(r))
                    .ToList();

                pokloni = s.Query<Poklon>().Select(x => new PoklonView(x)).ToList();
                dRad = s.Query<DeoRadionice>().Select(x => new DeoRadioniceView(x)).ToList();
                foreach (var igracka in igracke)
                {
                    foreach (var poklon in pokloni)
                    {
                        if ((igracka.PripadaPoklonu.ID == poklon.ID))
                            igracka.PripadaPoklonu = poklon;
                    }

                    foreach (var dr in dRad)
                    {
                        if (igracka.IzradjenaUDeluRadionice.ID == dr.ID)
                            igracka.IzradjenaUDeluRadionice = dr;
                    }
                }

            }
            catch (Exception e)
            {
                throw;
            }
            finally { s?.Flush(); s?.Close(); }
            return igracke;
        }

        public static bool azurirajIgracku(IgrackaView igracka)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                Igracka i = s.Load<Igracka>(igracka.ID);

                i.RedniBroj = igracka.RedniBroj;
                i.Tip = igracka.Tip;
                i.Opis = igracka.Opis;
                //da li reference i kako 

                s.SaveOrUpdate(i);
            }
            catch (Exception ex)
            {
                return false;

            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }


        public static bool obrisiIgracku(int id)
        {
            ISession s = null;
            try

            {
                s = DataLayer.GetSession();

                Igracka igr = s.Get<Igracka>(id);
                if (igr == null)
                {
                    throw new Exception("Ne postoji dete sa zadatim ID-jem");
                }


                s.Delete(igr);


            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

        public static bool obrisiListuZelja(int id)
        {
            ISession s = null;
            try

            {
                s = DataLayer.GetSession();

                Igracka igr = s.Get<Igracka>(id);
                if (igr == null)
                {
                    throw new Exception("Ne postoji dete sa zadatim ID-jem");
                }


                s.Delete(igr);


            }
            catch (Exception ex)
            {
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }

    }
}

