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
    public partial class AdministracijaForma : Form
    {
        public AdministracijaForma()
        {
            InitializeComponent();
        }

        private void btnDodajNovogVilenjaka_Click(object sender, EventArgs e)
        {
            DodajNovogVilenjakaForma noviVilenjak = new DodajNovogVilenjakaForma();
            noviVilenjak.ShowDialog();
        }

        private void btnAzurirajPodatkeOVilenjaku_Click(object sender, EventArgs e)
        {
            AzuriranjeVilenjakaForma azuriranje = new AzuriranjeVilenjakaForma();
            azuriranje.ShowDialog();
        }

        private void btnObrisiPostojecegVilenjaka_Click(object sender, EventArgs e)
        {
            BrisanjeVilenjaka brisanje = new BrisanjeVilenjaka();
            brisanje.ShowDialog();
        }

        private void btnDodajIrvasa_Click(object sender, EventArgs e)
        {
            DodajIrvasaForma dodajIrvasaForma = new DodajIrvasaForma();
            dodajIrvasaForma.ShowDialog();
        }

        private void btnObrisiIrvasa_Click(object sender, EventArgs e)
        {
            BrisanjeIrvasaForma bif = new BrisanjeIrvasaForma();
            bif.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAzurirajIrvasa_Click(object sender, EventArgs e)
        {
            AzuriranjeIrvasaForma aif = new AzuriranjeIrvasaForma();
            aif.ShowDialog();
        }

        private void btnDodajNovoPismo_Click(object sender, EventArgs e)
        {
            DodajPismoDeteForma pismoDete = new DodajPismoDeteForma();
            pismoDete.ShowDialog();
        }

       

        private void btnDodajRadionicu_Click(object sender, EventArgs e)
        {
            DodajRadionicuForma rad = new DodajRadionicuForma();
            rad.ShowDialog();
        }

        private void btnObrisiRadionicu_Click(object sender, EventArgs e)
        {
            ObrisiRadionicuForma rad=new ObrisiRadionicuForma();
            rad.ShowDialog();
        }

        private void btnDodajTim_Click(object sender, EventArgs e)
        {
            DodajTimForma tim = new DodajTimForma();
            tim.ShowDialog();
        }

        private void btnObrisiTim_Click(object sender, EventArgs e)
        {
            ObrisiTimForma tim = new ObrisiTimForma();
            tim.ShowDialog();
        }
    }
}
