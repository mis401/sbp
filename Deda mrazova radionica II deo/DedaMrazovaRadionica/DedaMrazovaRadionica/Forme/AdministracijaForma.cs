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
    }
}
