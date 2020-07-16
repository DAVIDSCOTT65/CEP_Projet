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
            LoadDatas("SELECT_ALL_MEMBRE_BAPTISER");
                
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadDatas("SELECT_MEMBRE_BAPTISER_CEP");
        }
        void LoadDatas(string proc)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    SelectDatas(new Baptiser(), proc);
                    lblTotal.Text = dgBaptiser.Rows.Count.ToString() + " Baptemes";
                }
                else if(radioButton2.Checked == true)
                {
                    SelectDatas(new Baptiser(), proc);
                    lblTotal.Text = dgBaptiser.Rows.Count.ToString() + " Baptemes";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            //Seach(new Baptiser());
        }
        void Seach(Baptiser b)
        {
            try
            {
                dgBaptiser.DataSource = b.Research(serchTxt.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmImpression fr = new FrmImpression();
                fr.RegistreBaptemes();
                fr.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
