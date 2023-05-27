using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DedaMrazovaRadionica.Forme
{
    public partial class ObrisiRadionicuForma : Form
    {
        public ObrisiRadionicuForma()
        {
            InitializeComponent();
            popuniRadionice();
        }

        private void popuniRadionice()
        {
            IList<DeoRadioniceBasic> radionice = DTOManager.vratiSveRadionice();
            foreach (var rad in radionice)
            {
                cbxDeoRadionice.Items.Add(rad.naziv);
            }
        }
        private void btnObrisiRadionicu_Click(object sender, EventArgs e)
        {
            if (DTOManager.obrisiDeoRadionice(cbxDeoRadionice.SelectedItem.ToString()))
            {
                MessageBox.Show("Obrisan je deo radionice");
            }
            else
            {
                MessageBox.Show("Brisanje neuspesno");
            }
        }
    }
}
