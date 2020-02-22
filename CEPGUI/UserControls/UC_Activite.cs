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

        private void UC_Activite_Load(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
            ChargerDataGrid(new OrganiserActivite());
        }
        void ChargerDataGrid(OrganiserActivite org)
        {
            dgActivite.DataSource = org.ListOfActivites();
        }
    }
}
