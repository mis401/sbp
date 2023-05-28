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
    public partial class DodajTimForma : Form
    {
        public DodajTimForma()
        {
            InitializeComponent();
            labNaziv.Hide();
        }

        private void btnDodajTim_Click(object sender, EventArgs e)
        {
             TimID tim  = new TimID(txtNazivTima.Text);

            IList<TimID> timovi = DTOManager.vratiNaziveTimova();
            foreach (var t in timovi)
            {
                if (t.naziv == tim.naziv)
                {
                    labNaziv.Show();
                    return;
                }
              
            }

            if (DTOManager.dodajTim(tim))
                MessageBox.Show("Uspesno dodat deo radionice! ");
        }
    }
}
