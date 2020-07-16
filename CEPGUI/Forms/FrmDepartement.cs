using CEPGUI.Class;
using DepartementLibrary;
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
    public partial class FrmDepartement : Form
    {
        public int id = 0;
        public FrmDepartement()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (departTxt.Text == "")
                    DynamicClasses.GetInstance().Alert("Champs vide détecté", DialogForms.FrmAlert.enmType.Error);
                else if (UserSession.GetInstance().Fonction == "Secrétaire" || UserSession.GetInstance().Fonction == "SA")
                {
                    Departements depart = new Departements();
                    depart.Id = id;
                    depart.Departement = departTxt.Text;

                    depart.SaveDatas(depart);

                    DynamicClasses.GetInstance().Alert("Département save", DialogForms.FrmAlert.enmType.Success);

                    departTxt.Clear();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
