using DedaMrazovaRadionica.Entiteti;
using DedaMrazovaRadionica.Forme;
using NHibernate;
using DedaMrazovaRadionica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DedaMrazovaRadionica
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void btnAdministracija_Click(object sender, EventArgs e)
        {
            AdministracijaForma administracija = new AdministracijaForma();
            administracija.ShowDialog();
        }

        private void btnSlanjePoklona_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            SlanjePoklonaForma slanjePoklona = new SlanjePoklonaForma();
            slanjePoklona.ShowDialog();
=======
            DodavanjeIgracakaForma dodavanjeIgracaka = new DodavanjeIgracakaForma();
            dodavanjeIgracaka.ShowDialog();
>>>>>>> eea386a205e3fabf15af7496aa13cd7212f619f5
        }
    }
}
