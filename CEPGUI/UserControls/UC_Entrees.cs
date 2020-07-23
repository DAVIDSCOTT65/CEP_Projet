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
using FinanceLibrary;
using CEPGUI.Class;

namespace CEPGUI.UserControls
{
    public partial class UC_Entrees : UserControl
    {
        DynamicClasses dn = new DynamicClasses();
        public UC_Entrees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEntree frm = new FrmEntree();
            frm.ShowDialog();
        }

        private void UC_Entrees_Load(object sender, EventArgs e)
        {
            SelectDatas(new Entree());
        }
        void SelectDatas(Entree ent)
        {
            try
            {
                dgFinance.DataSource = ent.ListOfEntree();
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
                 FrmEntree frm = new FrmEntree();
                    int i;
                    i = dgFinance.CurrentRow.Index;

                    frm.id = Convert.ToInt32(dgFinance["ColId", i].Value.ToString());
                    frm.valeur1D.Text = dgFinance["ColVal", i].Value.ToString();
                    frm.fcTxt.Text = dgFinance["ColFc", i].Value.ToString();
                    frm.dollarTxt.Text = dgFinance["ColDoll", i].Value.ToString();
                    frm.departCombo.Text = dgFinance["ColDepart", i].Value.ToString();
                    frm.sourceCombo.Text = dgFinance["ColSource", i].Value.ToString();
                    frm.concernDate.Text = dgFinance["ColDate", i].Value.ToString();

                    frm.ShowDialog();


            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(new Entree());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Search(Entree art)
        {
            dgFinance.DataSource = art.Research(serchTxt.Text);
        }

        private void dgFinance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dn.RapportEntreeToday();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dn.ExportInExcel(dgFinance);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelectDatas(new Entree());
        }

        private void dgFinance_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            doubleclic_grid();
        }
    }
}
