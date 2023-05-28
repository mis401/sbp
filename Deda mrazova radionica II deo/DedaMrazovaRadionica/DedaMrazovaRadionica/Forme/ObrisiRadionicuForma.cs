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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DedaMrazovaRadionica.Forme
{
    public partial class ObrisiRadionicuForma : Form
    {
        public ObrisiRadionicuForma()
        {
            InitializeComponent();
            popuniRadionice();
            listRadnici.Items.Clear();
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
            listRadnici.Items.Clear();
        }

        private void btnPrikaziRadnike_Click(object sender, EventArgs e)
        {
            //vrati radionicu iz cbx 
            //uzmi njen ID 
            //najdi vilenjake za izradu igracaka koji imaju ID dela radionice i vrati ih
            DeoRadionice deoRadionice = DTOManager.vratiRadionicu(cbxDeoRadionice.SelectedItem.ToString());
            int radID = deoRadionice.ID;

            IList<VilenjakZaIzraduIgracaka> radnici = DTOManager.vratiRadnike(radID);


            foreach (VilenjakZaIzraduIgracaka v in radnici)
            {
                ListViewItem item = new ListViewItem(new string[] { v.JedinstvenoIme, v.ZemljaPorekla, v.DatumZaposlenja.ToLongDateString() });
                listRadnici.Items.Add(item);
            }

            
        }
    }
}
