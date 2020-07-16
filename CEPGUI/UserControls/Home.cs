﻿using System;
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
using MembreLibrary;
using CommuniqueLibrary;
using BaptemeLibrary;
using MariageLibrary;
using CEPGUI.Forms;

namespace CEPGUI.UserControls
{
    public partial class Home : UserControl
    {
        Depenses dep = new Depenses();
        Departements d = new Departements();
        Membre m = new Membre();
        CommuniquerConcerner c = new CommuniquerConcerner();
        OrganiserActivite org = new OrganiserActivite();
        Baptiser b = new Baptiser();
        FaireMariage f = new FaireMariage();
        public Home()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("dd/MM/yyyy HH:MM:ss");
            LoadDatas();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //LoadDatas();
        }
        void LoadDatas()
        {
            try
            {
                lblCaisse.Text = dep.GetCaisse().ToString() + " Dollars";
                lblDepart.Text = d.CountDepartement().ToString() + " Departements";
                lblMembre.Text = m.CountMembre().ToString() + " Fidèles";
                lblAnnonce.Text = c.CountCommunique().ToString() + " Annonces";
                lblActiv.Text = org.CountActivite().ToString() + " Activités";
                lblBapeme.Text = b.CountBapteme().ToString() + " Baptemes";
                lblMariage.Text = f.CountMariage().ToString() + " Mariages";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEglise fr = new FrmEglise();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSms fr = new FrmSms();
                fr.radioAnnonce.Checked = true;
                fr.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSms fr = new FrmSms();
                fr.radioActivite.Checked = true;
                fr.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
