using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MariageLibrary;
using CEPGUI.Forms;

namespace CEPGUI.UserControls
{
    public partial class UC_Mariage : UserControl
    {
        public UC_Mariage()
        {
            InitializeComponent();
        }

        private void UC_Mariage_Load(object sender, EventArgs e)
        {
            SelectDatas(new FaireMariage());
        }
        void SelectDatas(FaireMariage f)
        {
            dgMariage.DataSource = f.ListOfMariageCelebrer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMariage fr = new FrmMariage();

            fr.ShowDialog();
        }
    }
}
