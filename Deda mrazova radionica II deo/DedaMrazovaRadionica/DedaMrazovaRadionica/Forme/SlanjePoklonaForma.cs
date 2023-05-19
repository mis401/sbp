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
    public partial class SlanjePoklonaForma : Form
    {
        public SlanjePoklonaForma()
        {
            InitializeComponent();
        }

        private void SlanjePoklonaForma_Load(object sender, EventArgs e)
        {
            popuniListuPismima();
        }

        private void popuniListuPismima()
        {
           
            listPisma.Items.Clear();

            IList<PismoPregled> pisma = DTOManager.vratiSvaPisma();

            foreach (PismoPregled p in pisma)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.tekst, p.indDobrote.ToString() });
                listPisma.Items.Add(item);
            }

            listPisma.Refresh();
        }

        private void btnDodajIgracke_Click(object sender, EventArgs e)
        {
        }

        private void listPisma_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
