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
    public partial class DodajPismoDeteForma : Form
    {
        public DodajPismoDeteForma()
        {
            InitializeComponent();
            gbxPismo.Hide();
        }

        private void btnDodajDete_Click(object sender, EventArgs e)
        {
            DeteBasic dete = new DeteBasic(txtIme.Text, txtPrezime.Text, txtGrad.Text, txtDrzava.Text,txtAdresa.Text, datumRodenjaDT.Value);
            if (DTOManager.dodajDete(dete))
            {
                MessageBox.Show("Dodato je dete " + dete.ime + " " + dete.prezime);
            }
            gbxPismo.Show();
        }

        private void btnDodajPismo_Click(object sender, EventArgs e)
        {

        }
    }
}
