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
    public partial class BrisanjeIrvasaForma : Form
    {
        public BrisanjeIrvasaForma()
        {
            InitializeComponent();
        }

        private void btnObrisiIrvasa_Click(object sender, EventArgs e)
        {
            if (DTOManagerBenc.obrisiIrvasa(txtIme.Text))
            {
                MessageBox.Show("Obrisan je irvas");
            }
            else
            {
                MessageBox.Show("Brisanje neuspesno");
            }
        }
    }
}
