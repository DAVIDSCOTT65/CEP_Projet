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
    public partial class FrmMariage : Form
    {
        PrevisionMariage pre = new PrevisionMariage();
        DynamicClasses dn = new DynamicClasses();
        public int idParrainage = 0;
        public int idPrevision = 0;
        public FrmMariage()
        {
            InitializeComponent();
        }

        private void FrmMariage_Load(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(cmbDate, "DatePasteur", "SELECT_DATE_PASTEUR");
            pre.AutoCompleteMode("AUTO_COMPLETE_CONJOINT", conjointTxt);
            pre.AutoCompleteMode("AUTO_COMPLETE_CONJOINTE", conjointeTxt);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            FrmAddMariage fr = new FrmAddMariage();
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(conjointeTxt.Text=="" || conjointTxt.Text=="" || conjointeTxt.Text == "Conjointe" || conjointTxt.Text == "Conjoint" || parrainTxt.Text=="" || marraineTxt.Text=="" || parrainTxt.Text == "Parrain" || marraineTxt.Text == "Marraine" || cmbDate.Text=="")
                {
                    MessageBox.Show("Champs vide detecté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    EnregistreParrainage();

                    PrevisionMariage pre = new PrevisionMariage();

                    pre.Id = idPrevision;
                    pre.RefMariage= dn.retourId(cmbDate.Text, "@design", "GET_ID_MARIAGE");
                    
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void EnregistreParrainage()
        {
            Parrainage p = new Parrainage();

            p.Id = idParrainage;
            p.Parrain = parrainTxt.Text;
            p.Marraine = marraineTxt.Text;

            p.SaveDatas(p);
        }

        private void conjointTxt_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
