using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEPGUI.Forms;
using CEPGUI.Class;
using MembreLibrary;

namespace CEPGUI.UserControls
{
    public partial class UC_Departements : UserControl
    {
        DynamicClasses dn = new DynamicClasses();
        public UC_Departements()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AffectactionDepartement frm = new AffectactionDepartement();
            frm.ShowDialog();
        }

        private void UC_Departements_Load(object sender, EventArgs e)
        {
            ChargementCombo();
            departCombo.SelectedIndex = 0;
        }
        void ChargementDataGrid(Membre m)
        {
            try
            {
                dgMembre.DataSource = m.ListOfMembersAndDepartment(departCombo.Text);
                CountFidele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur lors du chargement de la table : " + ex.Message);
            }
            
        }
        void CountFidele()
        {
            lblFidele.Text = dgMembre.Rows.Count.ToString() + " Fidèles";
        }
        void ChargementCombo()
        {
            try
            {
                dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur lors du chargement des départements : " + ex.Message);
            }
            
           
            
        }

        private void departCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(departCombo.Text != "")
                ChargementDataGrid(new Membre());
            
        }

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(new Membre());
                CountFidele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Search(Membre m)
        {
            dgMembre.DataSource = m.ResearchMembreInDepartement(serchTxt.Text,departCombo.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dn.ExportInExcel(dgMembre);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChargementDataGrid(new Membre());
        }
    }
}
