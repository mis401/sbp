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
        private Vilenjak vilenjak;
        private IList<MagicnaVestina> magicnaVestinaList;
        public AzuriranjeVilenjakaForma()
        {
            InitializeComponent();
            grupaIgracke.Hide();
            grupaIrvas.Hide();
            panelBasic.Hide();
            labelPogresnoIme.Hide();
            vilenjak=new Vilenjak();
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
            vilenjak = DTOManager.vratiVilenjaka(txtIme.Text);
            if (vilenjak != null )
            {
                panelBasic.Show();
                if (vilenjak is VilenjakZaIrvase)
                {
                    
                    grupaIgracke.Hide();
                    grupaIrvas.Show();
                    foreach(var vestina in (vilenjak as VilenjakZaIrvase).VilenjakZaIrvaseVestinaSpoj)
                    {
                        listVestine.Items.Add(vestina.MagicnaVestina.Naziv);//ne radi
                    }
                }
                else if (vilenjak is VilenjakZaIzraduIgracaka)
                {
                    grupaIrvas.Hide();
                    grupaIgracke.Show();
                    foreach (var vestina in (vilenjak as VilenjakZaIzraduIgracaka).VilenjakZaIgrackeVestinaSpoj)
                    {
                        listVestine.Items.Add(vestina.MagicnaVestina.Naziv);
                    }
                }
                
            }
            else
            {
                labelPogresnoIme.Show();
            }
        }
    }
}
