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
    public partial class ObrisiTimForma : Form
    {
        public ObrisiTimForma()
        {
            InitializeComponent();
            popuniTimove();
        }

        private void popuniTimove()
        {
            IList<TimID> timovi = DTOManager.vratiNaziveTimova();
            foreach (var t in timovi)
            {
                cbxTim.Items.Add(t.naziv);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (DTOManager.obrisiTim(cbxTim.SelectedItem.ToString()))
            {
                MessageBox.Show("Obrisan je tim");
            }
            else
            {
                MessageBox.Show("Brisanje neuspesno");
            }
        }
    }
}
