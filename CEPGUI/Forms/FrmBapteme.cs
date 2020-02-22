using CEPGUI.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPGUI.Forms
{
    public partial class Bapteme : Form
    {
        DynamicClasses dn = new DynamicClasses();
        public Bapteme()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMembre frm = new FrmMembre();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Bapteme_Load(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(membreCombo, "Noms", "SELECT_MEMBRE");
        }
    }
}
