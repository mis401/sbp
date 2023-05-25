using DedaMrazovaRadionica.Entiteti;
using NHibernate;
using NHibernate.Linq;
using DedaMrazovaRadionica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DedaMrazovaRadionica.Forme;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FluentNHibernate.Conventions;
using NHibernate.Context;
using FluentNHibernate;

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
            finally { s?.Flush(); s?.Close(); }
            return mentori;
        }
<<<<<<< HEAD
        public static bool dodajVilenjakaZaIgracke(VilenjakZaIzraduIgracakaBasic vib)
=======

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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
            }
            finally { s?.Flush(); s?.Close(); }
            return deloviRadionice;
        }

        public static bool dodajVilenjakaZaIgracke(VilenjakZaIzraduIgracaka form)
>>>>>>> eea386a205e3fabf15af7496aa13cd7212f619f5
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
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
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
                MessageBox.Show(ex.Message);
            }
            finally { s?.Close(); }
            return vilenjak;
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
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { s?.Flush(); s?.Close(); }
            return true;
        }
<<<<<<< HEAD

    
        public static IList<PismoPregled> vratiSvaPisma() //ne vraca nista
=======
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
>>>>>>> eea386a205e3fabf15af7496aa13cd7212f619f5
        {
            IList<PismoPregled> pisma = new List<PismoPregled>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                pisma = s.Query<Pismo>()
                    .Select(pismo => new PismoPregled(pismo.ID, pismo.Tekst, pismo.IndeksDobrote))
                    .ToList();

            }
            catch (Exception e)
            {
                MessageBox.Show("Neuspelo!");
            }
<<<<<<< HEAD
            finally { s?.Close(); }
            return pisma;
  
        }
}
    }
=======
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
                IrvasDTO irvas = new IrvasDTO(vilenjak.Irvas.ID, vilenjak.Irvas.Nadimak, vilenjak.Irvas.Starost);
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
                        vestine, new IrvasDTO(vilenjak.Irvas.ID, vilenjak.Irvas.Nadimak, vilenjak.Irvas.Starost));
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


        public static IList<PismoPregled> vratiSvaPisma()
        {
            IList<PismoPregled> pisma = new List<PismoPregled>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();



                pisma = s.Query<Pismo>()
                .Select(pismo => new PismoPregled(pismo.ID, pismo.Tekst, pismo.IndeksDobrote, pismo.PripadaDetetu))
                .ToList();



            }
            catch (Exception e)
            {
                MessageBox.Show("Neuspelo!");
            }
            finally { s?.Flush(); s?.Close(); }
            return pisma;

        }


        public static void dodajPoklon(PoklonBasic poklon)
        {
            ISession s = null;
            Poklon p = new Poklon();
            try
            {
                s = DataLayer.GetSession();

                p.Boja = poklon.boja;
                p.Posveta = poklon.posveta;
                p.ZaListuZelja = poklon.pripadaListiZelja;
                p.PripadaTovaru = poklon.pripadaTovaru;

                s.SaveOrUpdate(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { s?.Flush(); s?.Close(); }

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
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { s?.Flush(); s?.Close(); }
            return listazelja;
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
                MessageBox.Show(ex.Message);
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
                MessageBox.Show("Greska u vracanju pesama");
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

        /*public static IList<PismoPregled> vratiSvaPisma() //ne vraca nista
        {
            IList<PismoPregled> pisma = new List<PismoPregled>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();



                pisma = s.Query<Pismo>()
                .Select(pismo => new PismoPregled(pismo.ID, pismo.Tekst, pismo.IndeksDobrote, pismo.PripadaDetetu))
                .ToList();



            }
            catch (Exception e)
            {
                MessageBox.Show("Neuspelo!");
            }
            finally { s?.Close(); }
            return pisma;

        }*/


        /*public static int dodajPoklon(PoklonBasic poklon)
        {
            ISession s = null;
            Poklon p = new Poklon();
            try
            {
                s = DataLayer.GetSession();

                p.Boja = poklon.boja;
                p.Posveta = poklon.posveta;
                p.ZaListuZelja = poklon.pripadaListiZelja;
                p.PripadaTovaru = poklon.pripadaTovaru;

                s.SaveOrUpdate(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;

            }
            finally { s?.Close(); }
            return p.ID;

        }*/
        /*        public static ListaZelja dodajListuZelja(ListaZeljaBasic lz)
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
                        MessageBox.Show(ex.Message);
                        return null;
                    }
                    finally { s?.Close(); }
                    return listazelja;
                }*/

        /*        public static Tovar dodajTovar(TovarBasic tb)
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
                        MessageBox.Show(ex.Message);
                        return null;
                    }
                    finally { s?.Close(); }
                    return t;
                }*/

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
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { s?.Close(); }
            return igracka;
        }

        /*        public static Pismo vratiPismoID(int ID)
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
                        s?.Close();
                    }
                    return pismo;
                }*/

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
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s?.Close();
            }
            return listaZelja;
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
                MessageBox.Show(ex.Message);
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
            catch(Exception ex) { return false; }
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
    }

    

}

>>>>>>> eea386a205e3fabf15af7496aa13cd7212f619f5
