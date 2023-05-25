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
            grupaPokloni.Hide();
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
                    grupaPokloni.Hide();
                    grupaIrvas.Show();
                    foreach (var vestina in (vilenjak as VilenjakZaIrvaseSaVestinama).vestine)
                    {
                        listVestine.Items.Add(vestina.naziv);
                    }
                    txtTrenutniIrvas.Text = (vilenjak as VilenjakZaIrvaseSaVestinama).irvas.ime;
                    pesme = DTOManager.vratiPesme();
                    cmbPesme.Items.Clear();
                    foreach (var pesma in pesme)
                    {
                        cmbPesme.Items.Add(pesma.naziv);
                    }
                }
                else if (vilenjak is VilenjakZaIzraduIgracakaSaVestinama)
                {
                    grupaIrvas.Hide();
                    grupaPokloni.Hide();
                    grupaIgracke.Show();
                    var radionice = DTOManager.vratiNaziveRadionica();
                    var timovi = DTOManager.vratiNaziveTimova();
                    if ((vilenjak as VilenjakZaIzraduIgracakaSaVestinama).flagKoordinator == 1)
                        btnKoordinator.Enabled = false;
                    else
                        btnKoordinator.Enabled = true;
                    if ((vilenjak as VilenjakZaIzraduIgracakaSaVestinama).flagSef == 1)
                        btnSef.Enabled = false;
                    else
                        btnSef.Enabled = true;
                    foreach (var vestina in (vilenjak as VilenjakZaIzraduIgracakaSaVestinama).vestine)
                    {
                        listVestine.Items.Add(vestina.naziv);
                    }
                    foreach (var tim in timovi)
                    {
                        cmbTimovi.Items.Add(tim.naziv);
                    }
                    cmbTimovi.SelectedIndex = cmbTimovi.Items.IndexOf((vilenjak as VilenjakZaIzraduIgracakaSaVestinama).pripadaTimu.naziv);
                    foreach(var rad in radionice)
                    {
                        cmbRadionice.Items.Add(rad.naziv);
                    }
                    cmbRadionice.SelectedIndex = cmbRadionice.Items.IndexOf((vilenjak as VilenjakZaIzraduIgracakaSaVestinama).deoRadionice.naziv);
                }
                else if (vilenjak is VilenjakZaPokloneSaVestinama)
                {
                    grupaIrvas.Hide();
                    grupaIgracke.Hide();
                    grupaPokloni.Show();
                    
                    //pokloni = DTOManager.vratiPokloneVilenjaka(vilenjak);
                    tabelaPoklona.DataSource = (vilenjak as VilenjakZaPokloneSaVestinama).listaPoklona.Select(x => new { x.ID, Boja = x.boja, Posveta = x.posveta, Destinacija = x.destinacija, Dete = x.dete }).ToList();
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

        private void btnKoordinator_Click(object sender, EventArgs e)
        {
            if (DTOManager.unapredjenjeUKoordinatora(vilenjak))
            {
                MessageBox.Show($"Vilenjak {vilenjak.jedinstvenoIme} je sada koorinator tima {(string)cmbTimovi.SelectedItem}");
                btnKoordinator.Enabled = false;
            }
        }
        private void btnSef_Click(object sender, EventArgs e)
        {
            if (DTOManager.unapredjenjeUSefa(vilenjak))
            {
                MessageBox.Show($"Vilenjak {vilenjak.jedinstvenoIme} je sada sef radionice {(string)cmbRadionice.SelectedItem}");
                btnSef.Enabled = false;
            }
        }

        private void btnIzmenaTima_Click(object sender, EventArgs e) //ne radi
        {
            if(DTOManager.izmenaTima(vilenjak, (string)cmbTimovi.SelectedItem)
                && DTOManager.izmenaRadionice(vilenjak, (string)cmbRadionice.SelectedItem))
            {
                MessageBox.Show($"Vilenjak {vilenjak.jedinstvenoIme} " +
                    $"dodeljen je timu {(string)cmbTimovi.SelectedItem} " +
                    $"u radionici {(string)cmbRadionice.SelectedItem}");
            }
            vilenjak = DTOManager.vratiVilenjakaSaVestinama(vilenjak.jedinstvenoIme);
            if ((vilenjak as VilenjakZaIzraduIgracakaSaVestinama).flagSef == 1)
                btnSef.Enabled = false;
            else
                btnSef.Enabled = true;
            if ((vilenjak as VilenjakZaIzraduIgracakaSaVestinama).flagKoordinator == 1)
                btnKoordinator.Enabled = false;
            else
                btnKoordinator.Enabled = true;
        }
    }
}
