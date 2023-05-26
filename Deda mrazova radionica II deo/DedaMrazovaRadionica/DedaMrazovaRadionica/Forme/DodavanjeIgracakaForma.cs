using DedaMrazovaRadionica.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DedaMrazovaRadionica.Forme
{
    public partial class DodavanjeIgracakaForma : Form
    {
        
        private string tovarGrad;
        private int listaZeljaID;
        private int poklonID;
        private int rbrIgracke;
        private int vilenjakID;

        public DodavanjeIgracakaForma()
        {
            InitializeComponent();
            popuniIdPisma();
            labKreiranPoklon.Hide();
        }

      

        private void popuniListuPismima()
        {

            listPisma.Items.Clear();

            IList<PismoPregled> pisma = DTOManager.vratiSvaPisma();

            foreach (PismoPregled p in pisma)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.tekst, p.indDobrote.ToString(), p.dete.Ime, p.dete.Prezime });
                listPisma.Items.Add(item);
            }

            listPisma.Refresh();
        }
        
        private void DodavanjeIgracakaForma_Load(object sender, EventArgs e)
        {
            popuniListuPismima();
            popuniImenaVilenjakaZaIgracke();
        }

       private void popuniIdPisma()
        {
            IList<PismoPregled> pisma = DTOManager.vratiSvaPisma();
            foreach (var pismo in pisma)
            {
                cbxRbrPisma.Items.Add(pismo.ID);
            }
        }

        private void popuniImenaVilenjakaZaIgracke()
        {
            IList<VilenjakZaIzraduIgracakaPoklon> vilenjaci = DTOManager.vratiSveVilenjakeZaIgracke();
            foreach(var vilenjak in vilenjaci)
            {
                cbxVilenjaciZaIgracke.Items.Add(vilenjak.jedinstvenoIme);
            }
        }
        private void btnKreirajPoklon_Click(object sender, EventArgs e)
        {

            //prvo kreiramo listu zelja
            var pismo = cbxRbrPisma.SelectedItem;//as PismoBasic;
            Pismo p = DTOManager.vratiPismoID((int)pismo);

            ListaZeljaBasic lb = new ListaZeljaBasic(p);
            var lista = DTOManager.dodajListuZelja(lb);
            

            IList<PismoPregled> pisma = DTOManager.vratiSvaPisma();

            foreach(PismoPregled pismoPregled in pisma)
            {
                if(pismoPregled.ID == (int)cbxRbrPisma.SelectedItem)
                {
                    tovarGrad = pismoPregled.dete.Grad;
                    break;

                }
            }

            //dodamo tovar

            TovarBasic t = new TovarBasic(tovarGrad);
            var tovar = DTOManager.dodajTovar(t);

            //nakon toga kreiramo poklon

            PoklonBasic poklon = new PoklonBasic(txtBojaPoklona.Text, txtPosveta.Text, lista, tovar);

            DTOManager.dodajPoklon(poklon);

            labKreiranPoklon.Show();
            rbrIgracke = 0;
            

        }

        private void btnDodajIgrackeUPoklon_Click(object sender, EventArgs e)
        {
           /* rbrIgracke++;
            IList<VilenjakZaIzraduIgracakaPoklon> vilenjaci = DTOManager.vratiSveVilenjakeZaIgracke();
            string imeVilenjaka = cbxVilenjaciZaIgracke.SelectedItem.ToString();

            foreach(var v in vilenjaci)
            {
                if (v.jedinstvenoIme == imeVilenjaka)
                    vilenjakID = v.id;
            }


            VilenjakZaIzraduIgracaka vilenjak = DTOManager.vratiVilenjakaZaIzraduIgracaka(vilenjakID);

            DeoRadionice rad = vilenjak.DeoRadionice;

           // ListaZelja listaZelja = DTOManager.vratiListuZeljaSaNajvecimID();
            //Poklon p = DTOManager.vratiPoklonSaNajvecimID();

            IgrackaPregled igracka = new IgrackaPregled(rbrIgracke, txtTipIgracke.Text, txtOpisIgracke.Text, p, rad, listaZelja, vilenjak);

            DTOManager.dodajIgracka(igracka);*/



        }
    }
}
