﻿using ReceptionEnfantLibrary;
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
    public partial class FrmReceptionEnfant : Form
    {
        public int id = 0;
        string sex = "";
        public FrmReceptionEnfant()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enregistrer();
        }
        private void Enregistrer()
        {
            DateTime datenaissaissance;
            datenaissaissance = Convert.ToDateTime(naissTxt.Text);
            try
            {
                if (nomTxt.Text == "" || sex == "" || naissTxt.Text == "" || pereTxt.Text == "" || mereTxt.Text == "" || datenaissaissance.Date >= DateTime.Today)
                {
                    MessageBox.Show("Impossible d'enregistrer, Champs obligatoires vides ou dates supérieur", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    DateTime daterecpt;
                    daterecpt = Convert.ToDateTime(recptTxt.Text);
                    if (daterecpt > DateTime.Today)
                    {
                        MessageBox.Show("Impossible d'enregistrer une date de réception qui n'est pas encore arriver\n Laisser le champs date réception vide ou bien inserer une date valide", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else if (daterecpt.Date <= datenaissaissance.Date)
                    {
                        MessageBox.Show("Impossible d'enregistrer une date de réception inférieur à la date de naissance\n Laisser le champs date réception vide ou bien inserer une date valide", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        ReceptionEnfant r = new ReceptionEnfant();

                        r.Id = id;
                        r.Noms = nomTxt.Text;
                        r.Sexe = sex;
                        r.DateNaissance = Convert.ToDateTime(naissTxt.Text);
                        r.DateReception = Convert.ToDateTime(recptTxt.Text);
                        r.ProvOrigine = provTxt.Text;
                        r.TerrOrigine = terrTxt.Text;
                        r.Pere = pereTxt.Text;
                        r.Mere = mereTxt.Text;
                        r.Pasteur = pastTxt.Text;

                        r.SaveDatas(r);
                        //Initialisation des champs
                        Initialiser();
                        //Message de confirmation
                        MessageBox.Show("Enregistrement reussie", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Initialiser()
        {
            nomTxt.Clear();
            sex = "";
            rbtnM.Checked = false;
            rbtnF.Checked = false;
            naissTxt.Clear();
            recptTxt.Clear();
            pereTxt.Clear();
            mereTxt.Clear();
            provTxt.Clear();
            terrTxt.Clear();
            pastTxt.Clear();
        }

        private void rbtnM_CheckedChanged(object sender, EventArgs e)
        {
            sex = "M";
        }

        private void rbtnF_CheckedChanged(object sender, EventArgs e)
        {
            sex = "F";
        }
    }
}