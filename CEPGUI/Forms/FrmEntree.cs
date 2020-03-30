using CEPGUI.Class;
using FinanceLibrary;
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
    public partial class FrmEntree : Form
    {
        DynamicClasses dn = new DynamicClasses();
        public int id = 0;
        public FrmEntree()
        {
            InitializeComponent();
        }

        private void FrmEntree_Load(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
            dn.chargeNomsCombo(sourceCombo, "Designation", "SELECT_SOURCE_ENTREE");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDepartement frm = new FrmDepartement();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
            dn.chargeNomsCombo(sourceCombo, "Designation", "SELECT_SOURCE_ENTREE");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSource frm = new FrmSource();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserSession.GetInstance().Fonction == "Financier")
                Enregistrer();
            else
            {

            }
        }
        private void Enregistrer()
        {
            try
            {
                DateTime datepublication;
                datepublication = Convert.ToDateTime(concernDate.Text);
                if (Convert.ToDouble(montantTxt.Text) <= 0 || montantTxt.Text == "" || sourceCombo.Text == "" || datepublication.Date > DateTime.Today)
                    MessageBox.Show("Veuillez completé tous les champs svp ou vérifier la date ", "Champs vide", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    Entree ent = new Entree();


                    ent.Id = id;
                    ent.RefDepart = dn.retourId(departCombo.Text, "@design", "GET_ID_DEPART");
                    ent.RefSource = dn.retourId(sourceCombo.Text, "@designation", "GET_ID_SOURCE");
                    ent.Montant = Convert.ToDouble(montantTxt.Text);
                    ent.FC = Convert.ToDouble(fcTxt.Text);
                    ent.Dollar = Convert.ToDouble(dollarTxt.Text);
                    ent.DateConcernee = Convert.ToDateTime(concernDate.Text);

                    ent.SaveDatas(ent);



                    Initialise();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Initialise()
        {
            id = 0;
            montantTxt.Text = "0";
            departCombo.SelectedIndex = -1;
            sourceCombo.SelectedIndex = -1;
            fcTxt.Text = "0";
            dollarTxt.Text = "0";
            concernDate.Text = DateTime.Today.ToString();
        }

        private void montantTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsControl(e.KeyChar)) && !(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Valeur monnaitaire uniquement");
            }
        }

        private void montantTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fcTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsControl(e.KeyChar)) && !(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Valeur monnaitaire uniquement");
            }
        }

        private void dollarTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Valeur monnaitaire uniquement");
            }
        }

        private void fcTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
