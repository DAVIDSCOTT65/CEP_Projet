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
using CommuniqueLibrary;
using CEPGUI.Class;

namespace CEPGUI.UserControls
{
    public partial class UC_Communique : UserControl
    {
        DynamicClasses dn = new DynamicClasses();
        public UC_Communique()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnnonce frm = new FrmAnnonce();
            frm.ShowDialog();
        }

        private void UC_Communique_Load(object sender, EventArgs e)
        {
            
            dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
            departCombo.SelectedIndex = 0;
        }
        void SelectDatas(CommuniquerConcerner com,string depart)
        {
            dgCommunique.DataSource = com.ListOfCommuniquer(depart);
            lblAnnonce.Text = dgCommunique.Rows.Count.ToString() + " Annonces";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelectDatas(new CommuniquerConcerner(),departCombo.Text);
        }

        private void departCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            SelectDatas(new CommuniquerConcerner(),departCombo.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    departCombo.Text = "";
                    SelectDatas(new CommuniquerConcerner(), "Tous");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(new CommuniquerConcerner());
                lblAnnonce.Text = dgCommunique.Rows.Count.ToString() + " Annonces";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Search(CommuniquerConcerner m)
        {
            dgCommunique.DataSource = m.Research(serchTxt.Text, departCombo.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dn.ExportInExcel(dgCommunique);
        }
    }
}
