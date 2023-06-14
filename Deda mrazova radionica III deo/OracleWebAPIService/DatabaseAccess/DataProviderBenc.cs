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
    }
}

