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
    public partial class DodajRadionicuForma : Form
    {
        public DodajRadionicuForma()
        {
            InitializeComponent();
            labNaziv.Hide();
            labTipIgracke.Hide();
        }

        private void btnDodajRadionicu_Click(object sender, EventArgs e)
        {
            DeoRadioniceBasic deoRadionice = new DeoRadioniceBasic(txtNaziv.Text, txtTipIgracke.Text);

            IList<DeoRadioniceBasic> radionice = DTOManager.vratiSveRadionice();
            foreach(var r in radionice)
            {
                if (r.naziv == deoRadionice.naziv)
                {
                    labNaziv.Show();
                    return;
                }
                if(r.tipIgr == deoRadionice.tipIgr)
                {
                    labTipIgracke.Show(); 
                    return;
                }
            }

            if (DTOManager.dodajDeoRadionice(deoRadionice))
                MessageBox.Show("Uspesno dodat deo radionice! ");
        }
    }
}
