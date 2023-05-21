using DedaMrazovaRadionica.Entiteti;
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
    public partial class DodavanjeIgracakaForma : Form
    {
        
        private string tovarGrad;

        public DodavanjeIgracakaForma()
        {
            InitializeComponent();
            popuniIdPisma();
            label6.Enabled = false;
        }

        //U KREIRAJ POKLON DODAJ LISTU ZELJA, DODAJ TOVAR, NAKON TOGA KREIRAJ POKLON 
        //NAKON TOGA UNOS IGRACAKA

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
        }

       private void popuniIdPisma()
        {
            IList<PismoPregled> pisma = DTOManager.vratiSvaPisma();
            foreach (var pismo in pisma)
            {
                cbxRbrPisma.Items.Add(pismo.ID);
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
                if(pismoPregled.ID == cbxRbrPisma.SelectedIndex)
                {
                    tovarGrad = pismoPregled.dete.Grad;
                }
            }

            //dodamo tovar

            TovarBasic t = new TovarBasic(tovarGrad);
            var tovar = DTOManager.dodajTovar(t);

            //nakon toga kreiramo poklon

            PoklonBasic poklon = new PoklonBasic(0, txtBojaPoklona.Text, txtPosveta.Text, lista, tovar);

            DTOManager.dodajPoklon(poklon);

            label6.Enabled = true;

            

        }
    }
}
