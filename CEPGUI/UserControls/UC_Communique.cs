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
        void doubleclic_grid()
        {
            try
            {
                if (UserSession.GetInstance().Fonction == "Administrateur")
                {
                    FrmAnnonce frm = new FrmAnnonce();
                    int i;
                    i = dgCommunique.CurrentRow.Index;

                    frm.id = Convert.ToInt32(dgCommunique["ColId", i].Value.ToString());
                    frm.annonceTxt.Text = dgCommunique["ColAnnonce", i].Value.ToString();
                    frm.dateTxt.Text = dgCommunique["ColDate", i].Value.ToString();
                    frm.dgDepart.Rows.Add(dgCommunique["ColRefDepart", i].Value.ToString(), dgCommunique["ColDepart", i].Value.ToString());

                    frm.ShowDialog();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        private void UC_Communique_Load(object sender, EventArgs e)
        {
            
            dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
            //departCombo.SelectedIndex = 0;
            checkBox1.Checked = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            FrmImpression fr = new FrmImpression();
            fr.RegistreAnnonces("GetAnnonceToday");
            fr.ShowDialog();
        }

        private void dgCommunique_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            doubleclic_grid();
        }
    }
}
