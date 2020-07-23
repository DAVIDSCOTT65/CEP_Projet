using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MariageLibrary;
using CEPGUI.Forms;
using CEPGUI.Class;

namespace CEPGUI.UserControls
{
    public partial class UC_Mariage : UserControl
    {
        DynamicClasses dn = new DynamicClasses();
        public UC_Mariage()
        {
            InitializeComponent();
        }

        private void UC_Mariage_Load(object sender, EventArgs e)
        {
            SelectDatas(new FaireMariage());
            lblTotal.Text = dgMariage.RowCount.ToString() + " Mariages";
        }
        void SelectDatas(FaireMariage f)
        {
            try
            {
                dgMariage.DataSource = f.ListOfMariageCelebrer();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void doubleclic_grid()
        {
            try
            {
                FrmFaireMariage frm = new FrmFaireMariage();
                int i;
                i = dgMariage.CurrentRow.Index;

                frm.id = Convert.ToInt32(dgMariage["ColId", i].Value.ToString());
                frm.refprev = Convert.ToInt32(dgMariage["ColRefPrev", i].Value.ToString());
                frm.lblConjoint.Text = dgMariage["ColConjoint", i].Value.ToString();
                frm.lblParrain.Text = dgMariage["ColParrain", i].Value.ToString();
                frm.dateTxt.Text = dgMariage["ColDate", i].Value.ToString();
                frm.pastTxt.Text = dgMariage["ColPasteur", i].Value.ToString();
                frm.ShowDialog();



            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmMariage fr = new FrmMariage();

            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dn.ExportInExcel(dgMariage);
        }

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(new FaireMariage());
                lblTotal.Text = dgMariage.RowCount.ToString() + " Mariages";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Search(FaireMariage m)
        {
            dgMariage.DataSource = m.Research(serchTxt.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmImpression frm = new FrmImpression();
                frm.RegistreMariages();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelectDatas(new FaireMariage());
            lblTotal.Text = dgMariage.RowCount.ToString() + " Mariages";
        }

        private void dgMariage_DoubleClick(object sender, EventArgs e)
        {
            doubleclic_grid();
        }
    }
}
