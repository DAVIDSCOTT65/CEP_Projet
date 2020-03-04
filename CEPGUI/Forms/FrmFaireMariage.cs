using MariageLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPGUI.Forms
{
    public partial class FrmFaireMariage : Form
    {
        public int id = 0;
        public int refprev = 0;
        public FrmFaireMariage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enregistrer();
        }
        void Enregistrer()
        {
            try
            {
                DateTime datecelebr;
                datecelebr = Convert.ToDateTime(dateTxt.Text);

                if (refprev == 0 || datecelebr > DateTime.Today || pastTxt.Text == "")
                {
                    MessageBox.Show("Impossible d'enregistrer, Champs vides ou dates supérieur", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    FaireMariage fm = new FaireMariage();

                    fm.Id = id;
                    fm.RefPrev = refprev;
                    fm.DateMariage = Convert.ToDateTime(dateTxt.Text);
                    fm.Pasteur = pastTxt.Text;

                    fm.SaveDatas(fm);

                    MessageBox.Show(lblConjoint.Text + " mariés au " + dateTxt.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Initialiser();

                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Initialiser()
        {
            lblConjoint.Text = "";
            lblParrain.Text = "";
            dateTxt.Clear();
            pastTxt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
