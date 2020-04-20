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
using DepartementLibrary;
using CEPGUI.Class;

namespace CEPGUI.UserControls
{
    public partial class UC_Activite : UserControl
    {
        DynamicClasses dn = new DynamicClasses();
        public UC_Activite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmActivites frm = new FrmActivites();
            frm.ShowDialog();
        }
        void doubleclic_grid()
        {
            try
            {
                if (UserSession.GetInstance().Fonction == "Administrateur")
                {
                    FrmActivites frm = new FrmActivites();
                    int i;
                    i = dgActivite.CurrentRow.Index;

                    frm.id = Convert.ToInt32(dgActivite["ColId", i].Value.ToString());
                    frm.activCombo.Text = dgActivite["ColActivite", i].Value.ToString();
                    frm.descTxt.Text = dgActivite["ColDesc", i].Value.ToString();
                    //frm.dateTxt.Text = dgActivite["ColDate", i].Value.ToString();
                    frm.heureTxt.Text = dgActivite["ColHeure", i].Value.ToString();
                    //frm.departTxt.Text = dgActivite["ColDepart", i].Value.ToString();
                    frm.dgDepart.Rows.Add(dgActivite["ColRefDepart", i].Value.ToString(), dgActivite["ColDepart", i].Value.ToString());
                    frm.departTxt.SelectedIndex = -1;

                    frm.ShowDialog();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void UC_Activite_Load(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
            checkBox1.Checked = true;
        }
        void SelectDatas(OrganiserActivite org, string depart)
        {
            dgActivite.DataSource = org.ListOfActivites(depart);
            lblAnnonce.Text = dgActivite.Rows.Count.ToString() + " Activités";
        }

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            Search(new OrganiserActivite());
        }
        void Search(OrganiserActivite org)
        {
            dgActivite.DataSource = org.Research(serchTxt.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dn.ExportInExcel(dgActivite);
            FrmCalendar fr = new FrmCalendar();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
            //ChargerDataGrid(new OrganiserActivite());
        }

        private void departCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            SelectDatas(new OrganiserActivite(), departCombo.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    departCombo.Text = "";
                    SelectDatas(new OrganiserActivite(), "Tous");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgActivite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            doubleclic_grid();
        }
    }
}
