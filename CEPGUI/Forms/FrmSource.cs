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
    public partial class FrmSource : Form
    {
        public int id = 0;
        public FrmSource()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserSession.GetInstance().Fonction == "Financier" || UserSession.GetInstance().Fonction == "SA")
                Enregistrer();
            else
            {
                DynamicClasses.GetInstance().Alert("Niveau Finance Requis", DialogForms.FrmAlert.enmType.Warning);
            }
        }
        void Enregistrer()
        {
            try
            {
                if (designTxt.Text == "")
                    DynamicClasses.GetInstance().Alert("Champs vides détectés", DialogForms.FrmAlert.enmType.Error);
                else
                {
                    SourceEntree source = new SourceEntree();
                    source.Id = id;
                    source.Designation = designTxt.Text;

                    source.SaveDatas(source);

                    DynamicClasses.GetInstance().Alert("Source save", DialogForms.FrmAlert.enmType.Success);

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
