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
        public static VilenjakBasic vratiVilenjakaSaVestinama(string ime)
        {
            VilenjakBasic vilenjak = null;
            vilenjak = vratiVilenjakaZaIrvaseSaVestinama(ime);
            if (vilenjak != null)
                return vilenjak;
            vilenjak = vratiVilenjakaZaIzraduIgracakaSaVestinama(ime);
            if (vilenjak != null)
                return vilenjak;
            vilenjak = vratiVilenjakaZaPokloneSaVestinama(ime);
            if (vilenjak != null)
                return vilenjak;
            vilenjak = vratiVilenjakaZaIsporukuPoklona(ime);
            return vilenjak;

        }

        private static VilenjakBasic vratiVilenjakaZaIsporukuPoklona(string ime)
        {
            throw new NotImplementedException();
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
                    .ToList().First();
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
                    new DeoRadioniceID(vilenjak.DeoRadionice.ID, vilenjak.DeoRadionice.Naziv),
                    new TimID(vilenjak.PripadaTimu.ID, vilenjak.PripadaTimu.Naziv), vilenjak.DuzinaObuke, vilenjak.Ocena,
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
                s?.Flush(); s?.Close();
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
                s?.Flush(); s?.Close();
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

                IList<PoklonBasic> poklonBasics= new List<PoklonBasic>();
                foreach(var item in vilenjak.PakovanjePoklona)
                {
                    poklonBasics.Add(new PoklonBasic(item.Poklon.ID, item.Poklon.Boja, item.Poklon.Posveta, item.Poklon.ZaListuZelja, item.Poklon.PripadaTovaru));
                }
                v = new VilenjakZaPokloneSaVestinama(vilenjak.ID, vilenjak.JedinstvenoIme, vilenjak.ZemljaPorekla, vilenjak.DatumZaposlenja, poklonBasics);
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


        public static IList<PismoPregled> vratiSvaPisma() //ne vraca nista
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
            catch(Exception ex)
            {
                return false;
            }
            finally { s?.Flush();  s?.Close(); }
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
                finally { s?.Flush(); s?.Close();}
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
            catch(Exception ex)
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
            catch(Exception ex)
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
            catch(Exception ex)
            {
                return false;
            }
            finally { s.Flush(); s.Close();}
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
                foreach(var item in vilenjak.PakovanjePoklona)
                {
                    spakovaniPokloni.Add(item);
                }

                pokloni = spakovaniPokloni.Select(p => new PoklonBasic(p.Poklon.ID, p.Poklon.Boja, p.Poklon.Posveta, p.Poklon.ZaListuZelja, p.Poklon.PripadaTovaru)).ToList();
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

        public static IList<PismoPregled> vratiSvaPisma() //ne vraca nista
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

        }


        public static int dodajPoklon(PoklonBasic poklon)
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
            finally { s?.Close(); }
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
            finally { s?.Close(); }
            return t;
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { s?.Close(); }
            return igracka;
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
                s?.Close();
            }
            return pismo;
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
    }
    public class IgrackaPregled
    {
        public int ID;
        public int redniBroj;
        public string tip;
        public string opis;
        public Poklon pripadaPoklonu;
        public DeoRadionice izradjenaUDeluRadionice;
        public ListaZelja pripadaListiZelja;
        public VilenjakZaIzraduIgracaka vilenjak;


        public IgrackaPregled(int redniBroj, string tip, string opis, Poklon pripadaPoklonu, DeoRadionice izradjenaUDeluRadionice, ListaZelja pripadaListiZelja, VilenjakZaIzraduIgracaka vilenjak)
        {
            this.redniBroj = redniBroj;
            this.tip = tip;
            this.opis = opis;
            this.pripadaPoklonu = pripadaPoklonu;
            this.izradjenaUDeluRadionice = izradjenaUDeluRadionice;
            this.pripadaListiZelja = pripadaListiZelja;
            this.vilenjak = vilenjak;
        }
    }
    public class VilenjakZaIzraduIgracakaPoklon : VilenjakBasic
    {
        public string materijal;
        public TimID pripadaTimu;
        public DeoRadionice deoRadionice;
        public int duzinaObuke;
        public int ocena;
        public VilenjakZaIzraduIgracakaMentor mentor;
        public VilenjakZaIzraduIgracakaPoklon(int id,
            string jedIme, string zemPor, DateTime datZap, string materijal,
            DeoRadionice deoRadionice, TimID tim, int duzinaObuke, int ocena,
            VilenjakZaIzraduIgracakaMentor mentor) : base(id, jedIme, zemPor, datZap)
        {
            this.materijal = materijal;
            this.deoRadionice = deoRadionice;
            this.pripadaTimu = tim;
            this.duzinaObuke = duzinaObuke;
            this.ocena = ocena;
            this.mentor = mentor;
        }
    }
}
