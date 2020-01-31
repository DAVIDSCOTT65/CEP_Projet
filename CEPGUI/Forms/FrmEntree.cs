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
            Enregistrer();
        }
        private void Enregistrer()
        {
            try
            {
                if (Convert.ToDouble(montantTxt.Text) <= 0 || montantTxt.Text == "" || sourceCombo.Text == "")
                    MessageBox.Show("Veuillez completé tous les champs svp ", "Champs vide", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    Entree ent = new Entree();

                    
                        ent.Id = id;
                        ent.RefDepart = dn.retourId(departCombo.Text, "@design", "GET_ID_DEPART");
                        ent.RefSource = dn.retourId(sourceCombo.Text, "@designation", "GET_ID_SOURCE");
                        ent.Montant = Convert.ToDouble(montantTxt.Text);

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
        }
    }
}
