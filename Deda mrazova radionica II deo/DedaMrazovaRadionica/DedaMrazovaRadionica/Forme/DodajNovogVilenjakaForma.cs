using NHibernate;
using Prodavnica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DedaMrazovaRadionica.Forme
{
    public partial class DodajNovogVilenjakaForma : Form
    {
        private IList<VilenjakZaIzraduIgracakaMentor> mentori;
        private IList<DeoRadioniceID> radionice;
        private IList<TimID> timovi;
        public DodajNovogVilenjakaForma()
        {
            InitializeComponent();
            popuniVrsteVilenjaka();
            mentori = popuniMentor();
            radionice = popuniDeloveRadionice();
            timovi = popuniTimove();
        }

        private void popuniVrsteVilenjaka()
        {
            string[] tipVilenjaka = { "Vilenjak za irvase", "Vilenjak za isporuku poklona",
            "Vilenjak za izradu igračaka", "Vilenjak za pakovanje poklona"};

            foreach (string tip in tipVilenjaka)
            {
                comboVrstaVilenjaka.Items.Add(tip);
            }

        }
        private IList<DeoRadioniceID> popuniDeloveRadionice() 
        {
            IList<DeoRadioniceID> radionice = DTOManager.vratiNaziveRadionica();
            foreach(var radionica in radionice)
            {
                comboDeoRadionice.Items.Add(radionica.naziv);
            }
            return radionice;
        }

        private IList<VilenjakZaIzraduIgracakaMentor> popuniMentor()
        {
            IList<VilenjakZaIzraduIgracakaMentor> mentori = DTOManager.vratiSveMentore();
            foreach (VilenjakZaIzraduIgracakaMentor v in mentori)
                comboMentor.Items.Add(v.jedinstvenoIme);

            return mentori;
        }

        private IList<TimID> popuniTimove()
        {
            IList<TimID> timovi = DTOManager.vratiNaziveTimova();
            foreach(var tim in timovi)
                comboTim.Items.Add(tim.naziv);
            return timovi;
        }
        private void comboVrstaVilenjaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVrstaVilenjaka.SelectedIndex != 2)
            {
                comboMentor.Enabled = false;
                comboTim.Enabled = false;
                numDuzinaObuke.Enabled = false;
                numOcena.Enabled = false;
                comboDeoRadionice.Enabled = false;
                txtTipMaterijala.Enabled = false;
            }
            else
            {
                comboMentor.Enabled = true;
                comboTim.Enabled = true;
                numDuzinaObuke.Enabled = true;
                numOcena.Enabled = true;
                comboDeoRadionice.Enabled = true;
                txtTipMaterijala.Enabled = true;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (comboVrstaVilenjaka.SelectedIndex == 2)
            {
                Entiteti.DeoRadionice radionica = DTOManager.vratiRadionicu(radionice[comboDeoRadionice.SelectedIndex].id);
                Entiteti.Tim tim = DTOManager.vratiTim(timovi[comboTim.SelectedIndex].id);
                Entiteti.VilenjakZaIzraduIgracaka mentor = DTOManager.vratiVilenjakaZaIzraduIgracaka(mentori[comboMentor.SelectedIndex].id);

                try
                {
                    VilenjakZaIzraduIgracakaBasic vilenjak =
                        new VilenjakZaIzraduIgracakaBasic(0, txtIme.Text, txtZemljaPorekla.Text, datumZaposljavanja.Value,
                        txtTipMaterijala.Text, radionica,
                        tim, (int)numDuzinaObuke.Value,
                        (int)numOcena.Value, mentor);

                    if (DTOManager.dodajVilenjakaZaIgracke(vilenjak))
                        MessageBox.Show($"Dodavanje vilenjaka {vilenjak.jedinstvenoIme} je uspesno!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dodavanje neuspesno, " + ex.Message);
                }
            }
            else if (comboVrstaVilenjaka.SelectedIndex == 0) 
            {
                VilenjakZaIrvaseBasic vilenjak = new VilenjakZaIrvaseBasic(0, txtIme.Text, txtZemljaPorekla.Text, datumZaposljavanja.Value);
                if (DTOManager.dodajVilenjakaZaIrvase(vilenjak))
                    MessageBox.Show($"Dodat je vilenjak {vilenjak.jedinstvenoIme} uspesno!");
            }
        }
    }
}
