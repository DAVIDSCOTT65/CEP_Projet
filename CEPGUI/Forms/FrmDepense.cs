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
    public partial class FrmDepense : Form
    {
        DynamicClasses dn = new DynamicClasses();
        public int id = 0;
        public FrmDepense()
        {
            InitializeComponent();
        }

        private void FrmDepense_Load(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
            dn.chargeNomsCombo(sourceCombo, "Designation", "SELECT_DEPENSE");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmType frm = new FrmType();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDepartement frm = new FrmDepartement();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enregistrer();
        }
        private void Enregistrer()
        {
            try
            {
                Depenses dep = new Depenses();

                dep.Id = id;
                dep.RefDepart = dn.retourId(departCombo.Text, "@design", "GET_ID_DEPART");
                dep.RefType = dn.retourId(sourceCombo.Text, "@design", "GET_ID_TYPE");
                dep.Montant = Convert.ToDouble(montantTxt.Text);
                dep.SaveDatas(dep);

                Initialise();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Initialise()
        {
            departCombo.Text = "";
            sourceCombo.Text = "";
            montantTxt.Text = "0";
        }
    }
}
