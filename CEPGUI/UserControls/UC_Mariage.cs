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
            dgMariage.DataSource = f.ListOfMariageCelebrer();
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
            FrmImpression frm = new FrmImpression();
            frm.RegistreMariages();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelectDatas(new FaireMariage());
            lblTotal.Text = dgMariage.RowCount.ToString() + " Mariages";
        }
    }
}
