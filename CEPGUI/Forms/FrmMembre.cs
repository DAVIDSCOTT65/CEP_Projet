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
            DateTime datenaissaissance;
            datenaissaissance = Convert.ToDateTime(naissTxt.Text);
            try
            {
                if (nomTxt.Text == "" || sexe == "" || lieuTxt.Text == "" || datenaissaissance.Date >= DateTime.Today)
                {
                    MessageBox.Show("Impossible d'enregistrer, Champs vides ou dates supérieur", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if(baptTxt.Text != "")
                    {
                        DateTime dateBapt;
                        dateBapt = Convert.ToDateTime(baptTxt.Text);
                        if(dateBapt.Date>DateTime.Today)
                            MessageBox.Show("Impossible d'enregistrer une date de bapteme qui n'est pas encore arriver\n Laisser le champs date bapteme vide ou bien inserer une date valide", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        else if(dateBapt.Date<datenaissaissance.Date)
                        {
                            MessageBox.Show("Impossible d'enregistrer une date de bapteme inférieur à la date de naissance\n Laisser le champs date bapteme vide ou bien inserer une date valide", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                            m.DateBapteme = Convert.ToDateTime(baptTxt.Text);
                            m.Pere = pereTxt.Text;
                            m.Mere = mereTxt.Text;
                            m.ProvOrigine = provTxt.Text;
                            m.TerrOrigine = terrTxt.Text;
                            m.Telephone = phoneTxt.Text;
                            m.Pasteur = pastTxt.Text;
                            //Appel de la methode SaveDatas pour enregistrer dans la BDD
                            m.SaveDatas(m);
                            //Initialisation des champs
                            Initialiser();
                            //Message de confirmation
                            MessageBox.Show("Enregistrement reussie", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
            sexe = "";
            rbtnM.Checked = false;
            rbtnF.Checked = false;
            lieuTxt.Clear();
            naissTxt.Clear();
            baptTxt.Clear();
            pereTxt.Clear();
            mereTxt.Clear();
            provTxt.Clear();
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

        }
    }
}
