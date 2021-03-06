﻿using CEPGUI.Class;
using CEPGUI.DialogForms;
using MariageLibrary;
using MembreLibrary;
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
    public partial class FrmMembre : Form
    {
        public int id = 0;
        public string sexe = "";
        DynamicClasses dn = new DynamicClasses();
        PrevisionMariage pre = new PrevisionMariage();
        public FrmMembre()
        {
            InitializeComponent();
            this.ActiveControl = nomTxt;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enregistrer();
        }
        void Enregistrer()
        {
            
            try
            {
                DateTime datenaissaissance;
                datenaissaissance = Convert.ToDateTime(naissTxt.Text);
                if (nomTxt.Text == "" || sexe == "" || lieuTxt.Text == "" || datenaissaissance.Date >= DateTime.Today)
                {
                    dn.Alert("Champs vides détectés", FrmAlert.enmType.Error);
                }
                else if (UserSession.GetInstance().Fonction == "Secrétaire" || UserSession.GetInstance().Fonction == "SA")
                {
                    if(baptTxt.Text != "  /  /")
                    {
                        DateTime dateBapt;
                        dateBapt = Convert.ToDateTime(baptTxt.Text);
                        if(dateBapt.Date>DateTime.Today)
                            dn.Alert("Date pas encore arrivée", FrmAlert.enmType.Warning);
                        else if(dateBapt.Date <= datenaissaissance.Date)
                        {
                            dn.Alert("Vérifier date bapteme et naissance", FrmAlert.enmType.Warning);
                        }
                        else
                        {
                            Membre m = new Membre();
                            //Affectation des données dans la classe Membre
                            m.Id = id;
                            m.Noms = nomTxt.Text;
                            m.Sexe = sexe;
                            m.LieuNaissance = lieuTxt.Text;
                            m.DateNaissance = Convert.ToDateTime(naissTxt.Text);
                            m.DateBapteme = baptTxt.Text;
                            m.Pere = pereTxt.Text;
                            m.Mere = mereTxt.Text;
                            m.ProvOrigine = provTxt.Text;
                            m.TerrOrigine = terrTxt.Text;
                            m.Telephone = phoneTxt.Text;
                            m.Pasteur = pastTxt.Text;
                            //Appel de la methode SaveDatas pour enregistrer dans la BDD
                            m.SaveDatas(m);
                            dn.Alert("Membre save", FrmAlert.enmType.Success);

                        }
                    }
                    else
                    {
                        Membre m = new Membre();
                        //Affectation des données dans la classe Membre
                        m.Id = id;
                        m.Noms = nomTxt.Text;
                        m.Sexe = sexe;
                        m.LieuNaissance = lieuTxt.Text;
                        m.DateNaissance = Convert.ToDateTime(naissTxt.Text);
                        m.DateBapteme = "";
                        m.Pere = pereTxt.Text;
                        m.Mere = mereTxt.Text;
                        m.ProvOrigine = provTxt.Text;
                        m.TerrOrigine = terrTxt.Text;
                        m.Telephone = phoneTxt.Text;
                        m.Pasteur = pastTxt.Text;
                        //Appel de la methode SaveDatas pour enregistrer dans la BDD
                        m.SaveDatas(m);
                        dn.Alert("Membre save", FrmAlert.enmType.Success);
                    }
                    //Initialisation des champs
                    Initialiser();
                    //Message de confirmation
                    //MessageBox.Show("Enregistrement reussie", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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
            sexe = "";
            rbtnM.Checked = false;
            rbtnF.Checked = false;
            lieuTxt.Clear();
            naissTxt.Text = DateTime.Today.ToString();
            baptTxt.Text = DateTime.Today.ToString();
            pereTxt.Clear();
            mereTxt.Clear();
            provTxt.Text = "";
            terrTxt.Clear();
            phoneTxt.Clear();
            pastTxt.Clear();
        }

        private void rbtnM_CheckedChanged(object sender, EventArgs e)
        {
            sexe = "M";
        }

        private void rbtnF_CheckedChanged(object sender, EventArgs e)
        {
            sexe = "F";
        }

        private void FrmMembre_Load(object sender, EventArgs e)
        {
            pre.AutoCompleteMode("AUTO_COMPLETE_PERE", pereTxt);
            pre.AutoCompleteMode("AUTO_COMPLETE_MERE", mereTxt);
        }
    }
}
