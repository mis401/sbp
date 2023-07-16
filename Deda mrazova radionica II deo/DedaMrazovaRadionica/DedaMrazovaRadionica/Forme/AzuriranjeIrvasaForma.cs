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
    public partial class AzuriranjeIrvasaForma : Form
    {
        private Irvas irvasEntity;
        private IList<Irvas> irvasList;
        public AzuriranjeIrvasaForma()
        {
            InitializeComponent();
            irvasList = DTOManagerBenc.vratiSveIrvase();
            foreach(var irvas in irvasList)
            {
                cmbIrvasi.Items.Add(irvas.Nadimak);
            }
        }

        private void cmbIrvasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            irvasEntity = irvasList[cmbIrvasi.SelectedIndex];
            RedrawControls();
        }

        private void RedrawControls()
        {
            txtIme.Text = irvasEntity.Ime;
            txtNadimak.Text = irvasEntity.Nadimak;
            dateTimePicker1.Value= irvasEntity.DatumRodjenja;
            _ = irvasEntity.Pol == 'M' ? (radioMuski.Checked = true) : (radioZenski.Checked = true);
            //cmbIrvasi.Items[cmbIrvasi.SelectedIndex] = irvasEntity.Nadimak;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            char pol = radioMuski.Checked ? 'M' : 'Z';
            IrvasDTO idto = new IrvasDTO(irvasEntity.ID, txtIme.Text, txtNadimak.Text, pol, (DateTime.Now - dateTimePicker1.Value).Days);
            idto.datumRodjenja = dateTimePicker1.Value;
            if(DTOManagerBenc.azurirajIrvasa(irvasEntity, idto))
            {
                MessageBox.Show("Uspesno azuriran irvas");
            }
        }
    }
}
