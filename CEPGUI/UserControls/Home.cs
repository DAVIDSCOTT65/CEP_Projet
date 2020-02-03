using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceLibrary;
using DepartementLibrary;

namespace CEPGUI.UserControls
{
    public partial class Home : UserControl
    {
        Depenses dep = new Depenses();
        Departements d = new Departements();
        public Home()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("dd/MM/yyyy HH:MM:ss");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblCaisse.Text = dep.GetCaisse().ToString() + " Dollars";
            lblDepart.Text = d.CountDepartement().ToString() + " Departements";
        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
