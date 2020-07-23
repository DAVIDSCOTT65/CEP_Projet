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
            if (UserSession.GetInstance().Fonction == "Financier" || UserSession.GetInstance().Fonction == "SA")
                Enregistrer();
            else
            {
                dn.Alert("Niveau Finance Requis", DialogForms.FrmAlert.enmType.Warning);
            }
        }
        private void Enregistrer()
        {
            try
            {
                DateTime datepublication;
                datepublication = Convert.ToDateTime(concernDate.Text);
                if (fcTxt.Text=="" || dollarTxt.Text=="" || valeur1D.Text=="" || sourceCombo.Text == "" || datepublication.Date > DateTime.Today)
                    MessageBox.Show("Veuillez completé tous les champs svp ou vérifier la date ", "Champs vide", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    Entree ent = new Entree();
                    if (Convert.ToDouble(fcTxt.Text) > 0 && Convert.ToDouble(dollarTxt.Text) > 0)
                    {
                        if (Convert.ToDouble(valeur1D.Text) > 0)
                        {
                            ent.Id = id;
                            ent.RefDepart = dn.retourId(departCombo.Text, "@design", "GET_ID_DEPART");
                            ent.RefSource = dn.retourId(sourceCombo.Text, "@designation", "GET_ID_SOURCE");
                            ent.Montant = (Convert.ToDouble(fcTxt.Text) / Convert.ToDouble(valeur1D.Text)) + Convert.ToDouble(dollarTxt.Text);
                            ent.Valeur1Dollar = Convert.ToDouble(valeur1D.Text);
                            ent.FC = Convert.ToDouble(fcTxt.Text);
                            ent.Dollar = Convert.ToDouble(dollarTxt.Text);
                            ent.DateConcernee = Convert.ToDateTime(concernDate.Text);

                            ent.SaveDatas(ent);
                            dn.Alert("Entrées save", DialogForms.FrmAlert.enmType.Success);
                            Initialise();
                        }
                        else
                        {
                            MessageBox.Show("Entrez la valeur de 1$ SVP !", "Message");
                            //Initialise();
                        }
                            


                    }
                    else if (Convert.ToDouble(fcTxt.Text) <= 0 )
                    {
                        if (Convert.ToDouble(dollarTxt.Text) > 0)
                        {
                            ent.Id = id;
                            ent.RefDepart = dn.retourId(departCombo.Text, "@design", "GET_ID_DEPART");
                            ent.RefSource = dn.retourId(sourceCombo.Text, "@designation", "GET_ID_SOURCE");
                            ent.Montant = Convert.ToDouble(dollarTxt.Text);
                            ent.Valeur1Dollar = 0;
                            ent.FC = 0;
                            ent.Dollar = Convert.ToDouble(dollarTxt.Text);
                            ent.DateConcernee = Convert.ToDateTime(concernDate.Text);

                            ent.SaveDatas(ent);
                            dn.Alert("Entrées save", DialogForms.FrmAlert.enmType.Success);
                            Initialise();
                        }
                        else
                            MessageBox.Show("0$ n'est pas pris en compte !", "Message");


                        //ent.SaveDatas(ent);
                    }
                    else if(Convert.ToDouble(dollarTxt.Text) <= 0)
                    {
                        if (Convert.ToDouble(valeur1D.Text) > 0 && Convert.ToDouble(fcTxt.Text) > 0)
                        {
                            ent.Id = id;
                            ent.RefDepart = dn.retourId(departCombo.Text, "@design", "GET_ID_DEPART");
                            ent.RefSource = dn.retourId(sourceCombo.Text, "@designation", "GET_ID_SOURCE");
                            ent.Montant = (Convert.ToDouble(fcTxt.Text) / Convert.ToDouble(valeur1D.Text)) + 0;
                            ent.Valeur1Dollar = Convert.ToDouble(valeur1D.Text);
                            ent.FC = Convert.ToDouble(fcTxt.Text);
                            ent.Dollar = 0;
                            ent.DateConcernee = Convert.ToDateTime(concernDate.Text);

                            ent.SaveDatas(ent);
                            dn.Alert("Entrées save", DialogForms.FrmAlert.enmType.Success);
                            Initialise();

                            //ent.SaveDatas(ent);
                        }
                        else
                            MessageBox.Show("Entrez la valeur de 1$ SVP !", "Message");
                        
                    }
                    


                    //ent.SaveDatas(ent);
                    //dn.Alert("Entrées save", DialogForms.FrmAlert.enmType.Success);

                    //Initialise();

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
            valeur1D.Text = "0";
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

        private void fcTxt_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(fcTxt.Text) > 0)
                {
                    valeur1D.Enabled = false;
                }
                else if (Convert.ToDouble(fcTxt.Text) <= 0)
                    valeur1D.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fcTxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(fcTxt.Text) > 0)
                {
                    valeur1D.Enabled = true;
                }
                else if (Convert.ToDouble(fcTxt.Text) <= 0)
                    valeur1D.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
