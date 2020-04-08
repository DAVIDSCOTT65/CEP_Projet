using CEPGUI.Class;
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
    public partial class FrmAddMariage : Form
    {
        public int id = 0;
        public FrmAddMariage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enregistre();
        }
        void Enregistre()
        {
            try
            {
                DateTime datecelebr;
                datecelebr = Convert.ToDateTime(dateTxt.Text);
                if (lieuTxt.Text == "" || dateTxt.Text == "" || pastTxt.Text == "" || datecelebr < DateTime.Today)
                {
                    MessageBox.Show("Impossible d'enregistrer, Champs vides ou dates supérieur", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Mariage m = new Mariage();

                    m.Id = id;
                    m.DateCelebration = Convert.ToDateTime(dateTxt.Text);
                    m.Pasteur = pastTxt.Text;

                    m.SaveDatas(m);

                    DynamicClasses.GetInstance().Alert("Date mariage save", DialogForms.FrmAlert.enmType.Success);

                    Initialise();
                }

            }
            catch (Exception ex)
            {
                if (dateTxt.Text == "  /  /")
                    MessageBox.Show("Date vide");
                MessageBox.Show(ex.Message);
            }
        }
        void Initialise()
        {
            id = 0;
            lieuTxt.Clear();
            dateTxt.Text = DateTime.Today.ToString();
            pastTxt.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
