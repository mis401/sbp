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
    public partial class BrisanjeVilenjaka : Form
    {
        public BrisanjeVilenjaka()
        {
            InitializeComponent();
        }

        private void btnObrisiVilenjaka_Click(object sender, EventArgs e)
        {
            var ime = txtImeVilenjaka.Text;
            if (DTOManager.obrisiVilenjaka(ime))
            {
                MessageBox.Show("Obrisan je vilenjak " + ime);
            }
        }
    }
}
