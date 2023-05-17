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
    public partial class DodajNovogVilenjakaForma : Form
    {
        public DodajNovogVilenjakaForma()
        {
            InitializeComponent();
            popuniVrsteVilenjaka();
            popuniMentor();
         
        }

        private void popuniVrsteVilenjaka()
        {
            string[] tipVilenjaka = { "Vilenjak za irvase", "Vilenjak za isporuku poklona",
            "Vilenjak za izradu igračaka", "Vilenjak za pakovanje poklona"};

            foreach (string tip in tipVilenjaka)
            {
                comboVrstaVilenjaka.Items.Add(tip);
            }

        }

        private void popuniMentor()
        {
            List<VilenjakZaIzraduIgracakaMentor> mentori = DTOManager.vratiSveMentore();
            foreach (VilenjakZaIzraduIgracakaMentor v in mentori)
                comboMentor.Items.Add(v.jedinstvenoIme);
        }
        private void comboVrstaVilenjaka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

    }
}
