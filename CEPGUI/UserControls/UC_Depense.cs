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
    public partial class UC_Depense : UserControl
    {
        DynamicClasses dn = new DynamicClasses();
        public UC_Depense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDepense frm = new FrmDepense();
            frm.ShowDialog();
        }

        private void UC_Depense_Load(object sender, EventArgs e)
        {
            SelectDatas(new Depenses());
        }
        void doubleclic_grid()
        {
            try
            {
                if (UserSession.GetInstance().Fonction == "Administrateur")
                {
                    FrmDepense frm = new FrmDepense();
                    int i;
                    i = dgFinance.CurrentRow.Index;

                    frm.id = Convert.ToInt32(dgFinance["ColId", i].Value.ToString());
                    frm.montantTxt.Text = dgFinance["ColMont", i].Value.ToString();
                    frm.departCombo.Text = dgFinance["ColDepart", i].Value.ToString();
                    frm.sourceCombo.Text = dgFinance["ColSource", i].Value.ToString();

                    frm.ShowDialog();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        void SelectDatas(Depenses dep)
        {
            try
            {
                dgFinance.DataSource = dep.ListOfDepenses();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgFinance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(new Depenses());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }
        void Search(Depenses art)
        {
            dgFinance.DataSource = art.Research(serchTxt.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dn.RapportDepensesToday();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelectDatas(new Depenses());
        }

        private void dgFinance_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            doubleclic_grid();
        }
    }
}
