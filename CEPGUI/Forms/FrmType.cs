using CEPGUI.Class;
using FinanceLibrary;
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
    public partial class FrmType : Form
    {
        public int id = 0;
        public FrmType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Save()
        {
            try
            {
                if(designTxt.Text=="")
                    DynamicClasses.GetInstance().Alert("Champs vides détectés", DialogForms.FrmAlert.enmType.Error);
                else
                {
                    TypeDepense typ = new TypeDepense();
                    typ.Id = id;
                    typ.Designation = designTxt.Text;

                    typ.SaveDatas(typ);

                    DynamicClasses.GetInstance().Alert("Type save", DialogForms.FrmAlert.enmType.Success);

                    designTxt.Clear();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
