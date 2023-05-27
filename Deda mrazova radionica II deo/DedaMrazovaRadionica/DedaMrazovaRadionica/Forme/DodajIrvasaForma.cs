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
    public partial class DodajIrvasaForma : Form
    {

        Irvas irvas = new Irvas();
        public DodajIrvasaForma()
        {
            InitializeComponent();
            radioMuski.Select();
            
        }

        private void radioMuski_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            char pol = radioMuski.Checked ? 'M' : 'Z';
            irvas.Ime = txtIme.Text;
            irvas.Nadimak = txtNadimak.Text;
            irvas.Pol = pol;
            irvas.DatumRodjenja = dateTimePicker1.Value;
            if (DTOManagerBenc.dodajIrvasa(irvas))
            {
                MessageBox.Show($"Dodat je irvas {irvas.Ime}, sa nadimkom {irvas.Nadimak}");
            }
        }
    }
}
