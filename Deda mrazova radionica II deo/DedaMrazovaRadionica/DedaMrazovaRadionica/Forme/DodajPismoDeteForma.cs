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
    public partial class DodajPismoDeteForma : Form
    {
        private DeteBasic kiddo;
        public DodajPismoDeteForma()
        {
            InitializeComponent();
            gbxPismo.Hide();
        }

        private void btnDodajDete_Click(object sender, EventArgs e)
        {
            DeteRoditelj r1 = new DeteRoditelj();
            r1.Roditelj = txtRoditelj1.Text;
            DeteRoditelj r2 = new DeteRoditelj();
            r2.Roditelj = txtRoditelj2.Text;
            DeteRoditeljDTO dete = new DeteRoditeljDTO(txtIme.Text, txtPrezime.Text, txtGrad.Text, txtDrzava.Text,txtAdresa.Text, datumRodenjaDT.Value, r1, r2);
            if (DTOManager.dodajDete(dete))
            {
                MessageBox.Show("Dodato je dete " + dete.ime + " " + dete.prezime);
            }
            gbxPismo.Show();
            kiddo = dete;
        }

        private void btnDodajPismo_Click(object sender, EventArgs e)
        {
            PismoBasic pismo = new PismoBasic
                (0, textBox6.Text, (int)numericUpDown1.Value, 
                dateTimePicker2.Value, dateTimePicker3.Value, 
                kiddo);

            if (DTOManager.dodajPismo(pismo))
            {
                MessageBox.Show($"Dodato je pismo {pismo.ID} detetu {kiddo.ime}");
            }
        }
    }
}
