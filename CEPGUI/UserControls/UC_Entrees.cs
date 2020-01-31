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

namespace CEPGUI.UserControls
{
    public partial class UC_Entrees : UserControl
    {
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
            dgFinance.DataSource = ent.ListOfEntree();
        }
    }
}
