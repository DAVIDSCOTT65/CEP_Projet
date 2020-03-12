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
            dgRecept.DataSource = r.ListOfEnfantsRecu();
            
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
    }
}
