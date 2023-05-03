using DedaMrazovaRadionica.Entiteti;
using NHibernate;
using Prodavnica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DedaMrazovaRadionica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Proba_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                DeoRadionice dr = s.Load<DeoRadionice>(3);

                MessageBox.Show(dr.Naziv);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
