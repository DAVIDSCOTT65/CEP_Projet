using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReceptionEnfantLibrary;
using CEPGUI.Class;
using CEPGUI.Forms;

namespace CEPGUI.UserControls
{
    public partial class UC_Reception : UserControl
    {
        DynamicClasses dn = new DynamicClasses();
        public UC_Reception()
        {
            InitializeComponent();
        }

        private void UC_Reception_Load(object sender, EventArgs e)
        {
            SelectDatas(new ReceptionEnfant());
            lblTotal.Text = dgRecept.Rows.Count.ToString() + " Enfants";
        }
        void SelectDatas(ReceptionEnfant r)
        {
            try
            {
                dgRecept.DataSource = r.ListOfEnfantsRecu();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dgRecept.RowCount!=0)
            {
                dn.ExportInExcel(dgRecept);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmImpression frm = new FrmImpression();
            frm.RegistreReceptionEnfant();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmReceptionEnfant fr = new FrmReceptionEnfant();
            fr.ShowDialog();
        }
        void doubleclic_grid()
        {
            try
            {
                if (UserSession.GetInstance().Fonction == "Administrateur")
                {
                    FrmReceptionEnfant frm = new FrmReceptionEnfant();
                    int i;
                    i = dgRecept.CurrentRow.Index;

                    frm.label6.Text = "Modifier infos du membre";

                    frm.id = Convert.ToInt32(dgRecept["ColId", i].Value.ToString());
                    frm.nomTxt.Text = dgRecept["ColNom", i].Value.ToString();
                    frm.naissTxt.Text = dgRecept["ColNaiss", i].Value.ToString();
                    frm.recptTxt.Text = dgRecept["ColRecept", i].Value.ToString();
                    frm.pereTxt.Text = dgRecept["ColPere", i].Value.ToString();
                    frm.mereTxt.Text = dgRecept["ColMere", i].Value.ToString();
                    frm.provTxt.Text = dgRecept["ColProv", i].Value.ToString();
                    frm.terrTxt.Text = dgRecept["ColTerr", i].Value.ToString();
                    frm.pastTxt.Text = dgRecept["ColPast", i].Value.ToString();

                    if (dgRecept["ColSexe", i].Value.ToString() == "M")
                    {
                        frm.rbtnM.Checked = true;
                    }
                    else
                    {
                        frm.rbtnF.Checked = true;
                    }

                    frm.ShowDialog();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void dgRecept_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgRecept_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            doubleclic_grid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelectDatas(new ReceptionEnfant());
            lblTotal.Text = dgRecept.Rows.Count.ToString() + " Enfants";
        }

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
