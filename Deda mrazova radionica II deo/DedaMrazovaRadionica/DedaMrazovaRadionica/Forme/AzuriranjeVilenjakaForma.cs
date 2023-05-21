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
    public partial class AzuriranjeVilenjakaForma : Form
    {
        private VilenjakBasic vilenjak;
        private Vilenjak vilenjakEntitet;
        private IList<MagicnaVestina> magicnaVestinaList;
        private IList<PesmaDTO> pesme;
        private IList<PoklonBasic> pokloni;
        public AzuriranjeVilenjakaForma()
        {
            InitializeComponent();
            grupaIgracke.Hide();
            grupaIrvas.Hide();
            panelBasic.Hide();
            labelPogresnoIme.Hide();
            vilenjak=new VilenjakBasic();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AzuriranjeVilenjakaForma_Load(object sender, EventArgs e)
        {

        }

        private IList<MagicnaVestina> popuniMagicneVestine()
        {
            IList<MagicnaVestina> lista = DTOManager.vratiMagicneVestine();
            return lista;
        }
        private void btnNadji_Click(object sender, EventArgs e)
        {
            labelPogresnoIme.Hide();
            listVestine.Items.Clear();
            vilenjak = DTOManager.vratiVilenjakaSaVestinama(txtIme.Text);
            if (vilenjak != null )
            {
                panelBasic.Show();
                if (vilenjak is VilenjakZaIrvaseSaVestinama)
                {
                    grupaIgracke.Hide();
                    panelPokloni.Hide();
                    grupaIrvas.Show();
                    foreach (var vestina in (vilenjak as VilenjakZaIrvaseSaVestinama).vestine)
                    {
                        listVestine.Items.Add(vestina.naziv);
                    }
                    txtTrenutniIrvas.Text = (vilenjak as VilenjakZaIrvaseSaVestinama).irvas.ime;
                    pesme = DTOManager.vratiPesme();
                    cmbPesme.Items.Clear();
                    foreach(var pesma in pesme)
                    {
                        cmbPesme.Items.Add(pesma.naziv);
                    }
                }
                else if (vilenjak is VilenjakZaIzraduIgracakaSaVestinama)
                {
                    grupaIrvas.Hide();
                    panelPokloni.Hide();
                    grupaIgracke.Show();
                    foreach(var vestina in (vilenjak as VilenjakZaIzraduIgracakaSaVestinama).vestine)
                    {
                        listVestine.Items.Add(vestina.naziv);
                    }
                }
                else if (vilenjak is VilenjakZaPoklone)
                {
                    grupaIrvas.Hide();
                    grupaIgracke.Hide();
                    panelPokloni.Show();
                    pokloni = DTOManager.vratiPokloneVilenjaka(vilenjak);
                    foreach(var item in pokloni)
                    {
                        listaPokloni.Items.Add(item);
                    }
                }
                
            }
            else
            {
                labelPogresnoIme.Show();
            }
        }

        private void btnDodajPesmuVilenjaku_Click(object sender, EventArgs e)
        {
            if(DTOManager.dodajPesmuVilenjaku(pesme[cmbPesme.SelectedIndex].naziv, vilenjak))
            {
                MessageBox.Show("Dodata pesma");
            }
        }

        private void txtImePesme_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUkloniPesmuVilenjaku_Click(object sender, EventArgs e)
        {
            if(DTOManager.ukloniPesmuVilenjaku(pesme[cmbPesme.SelectedIndex].naziv, vilenjak))
            {
                cmbPesme.Items.Remove(cmbPesme.SelectedItem);
                txtPesme.Text = "";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDodajVestinu_Click(object sender, EventArgs e)
        {
            //var vestina = DTOManager.vratiMagicnuVestinu(txtNovaVestina.Text);
            if (DTOManager.dodajVestinuVilenjaku(txtNovaVestina.Text, vilenjak))
            listVestine.Items.Add(txtNovaVestina.Text);
        }

        private void btnPromeniIme_Click(object sender, EventArgs e)
        {
            if (DTOManager.promeniImeVilenjaku(txtNovoIme.Text, vilenjak))
            {

                MessageBox.Show($"Uspesno promenjeno ime vilenjaka iz {vilenjak.jedinstvenoIme} u {txtNovoIme}");
                txtIme.Text = txtNovoIme.Text;
            }
        }

        private void buttonUkloniVestinu_Click(object sender, EventArgs e)
        {
            if(DTOManager.ukloniVestinuVilenjaku(txtNovaVestina.Text, vilenjak))
            {
                listVestine.Items.Remove(txtNovaVestina.Text);
            }
        }

        private void btnPromeniIrvasa_Click(object sender, EventArgs e)
        {
            if (DTOManager.promeniIrvasaVilenjaku(txtNoviIrvas.Text, vilenjak)){
                MessageBox.Show("Uspesno promenjen irvas");
            }
        }

        private void cmbPesme_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesme.Text = pesme[cmbPesme.SelectedIndex].tekst;
        }
    }
}
