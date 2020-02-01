﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEPGUI.Forms;
using FinanceLibrary;

namespace CEPGUI.UserControls
{
    public partial class UC_Depense : UserControl
    {
        public UC_Depense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDepense frm = new FrmDepense();
            frm.ShowDialog();
        }

        private void UC_Depense_Load(object sender, EventArgs e)
        {
            SelectDatas(new Depenses());
        }
        void SelectDatas(Depenses dep)
        {
            dgFinance.DataSource = dep.ListOfDepenses();
        }

        private void dgFinance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
