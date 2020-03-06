using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaptemeLibrary;
using CEPGUI.Class;
using CEPGUI.Forms;

namespace CEPGUI.UserControls
{
    public partial class UC_Bapteme : UserControl
    {
        DynamicClasses dn = new DynamicClasses();
        public UC_Bapteme()
        {
            InitializeComponent();
            radioButton2.Checked = true;
        }

        private void UC_Bapteme_Load(object sender, EventArgs e)
        {
            
        }
        void SelectDatas(Baptiser b, string proc)
        {
            dgBaptiser.DataSource = b.ListOfBaptiser(proc);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                SelectDatas(new Baptiser(), "SELECT_ALL_MEMBRE_BAPTISER");
                lblTotal.Text = dgBaptiser.Rows.Count.ToString() + " Baptemes";
            }
                
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                SelectDatas(new Baptiser(), "SELECT_MEMBRE_BAPTISER_CEP");
                lblTotal.Text = dgBaptiser.Rows.Count.ToString() + " Baptemes";
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dn.ExportInExcel(dgBaptiser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBapteme fr = new FrmBapteme();

            fr.ShowDialog();
        }
    }
}
