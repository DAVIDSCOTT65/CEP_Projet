﻿using CEPGUI.Class;
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
    public partial class FrmDepense : Form
    {
        DynamicClasses dn = new DynamicClasses();
        Depenses dep = new Depenses();
        public int id = 0;
        double number = 0;

        public FrmDepense()
        {
            InitializeComponent();
        }

        private void FrmDepense_Load(object sender, EventArgs e)
        {
            number = dep.GetCaisse();
            dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
            dn.chargeNomsCombo(sourceCombo, "Designation", "SELECT_DEPENSE");
            lblCaiss.Text = number.ToString(".##");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmType frm = new FrmType();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDepartement frm = new FrmDepartement();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserSession.GetInstance().Fonction == "Financier" || UserSession.GetInstance().Fonction == "SA")
                Enregistrer();
            else
            {
                dn.Alert("Niveau Finance Requis", DialogForms.FrmAlert.enmType.Warning);
            }
        }
        private void Enregistrer()
        {
            try
            {

                if (Convert.ToDouble(montantTxt.Text) > Convert.ToDouble(lblCaiss.Text) || Convert.ToDouble(montantTxt.Text) <= 0 || sourceCombo.Text == "")
                    MessageBox.Show("Montant négatif ou montant supérieur au montant en caisse\nOu Completez tous les champs obligatoires.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    dep.Id = id;
                    dep.RefDepart = dn.retourId(departCombo.Text, "@design", "GET_ID_DEPART");
                    dep.RefType = dn.retourId(sourceCombo.Text, "@design", "GET_ID_TYPE");
                    dep.Montant = Convert.ToDouble(montantTxt.Text);
                    dep.SaveDatas(dep);

                    dn.Alert("Dépense enregistrée", DialogForms.FrmAlert.enmType.Success);

                    Initialise();

                    number = dep.GetCaisse();
                    lblCaiss.Text = number.ToString(".##");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Initialise()
        {
            departCombo.Text = "";
            sourceCombo.Text = "";
            montantTxt.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
            dn.chargeNomsCombo(sourceCombo, "Designation", "SELECT_DEPENSE");
            number = dep.GetCaisse();
            lblCaiss.Text = number.ToString(".##");
        }

        private void montantTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsControl(e.KeyChar)) && !(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Valeur monnaitaire uniquement");
            }
        }
    }
}
