using CEPGUI.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitiesLibrary;

namespace CEPGUI.Forms
{
    public partial class FrmAgent : Form
    {
        public int idAgent = 0;
        string sexe = "";
        public FrmAgent()
        {
            InitializeComponent();
        }

        private void FrmAgent_Load(object sender, EventArgs e)
        {
            if (UserSession.GetInstance().Fonction != "Administrateur" || UserSession.GetInstance().Fonction != "SA")
                lblWarning.Visible = true;
        }

        private void rbtnMasc_CheckedChanged(object sender, EventArgs e)
        {
            sexe = "M";
        }

        private void rbtnFem_CheckedChanged(object sender, EventArgs e)
        {
            sexe = "F";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserSession.GetInstance().Fonction == "Administrateur" || UserSession.GetInstance().Fonction == "SA")
                {
                    if (nomsTxt.Text == "" || adresseTxt.Text == "" || fonctionTxt.Text == "" || phoneTxt.Text == "" || emailTxt.Text == "" || sexe == "")
                    {
                        DynamicClasses.GetInstance().Alert("Completez tous les champs !", DialogForms.FrmAlert.enmType.Info);
                    }
                    else if(passTxt.Text != "" && passConfTxt.Text != "")
                    {
                        if ((passTxt.Text != passConfTxt.Text) )
                            DynamicClasses.GetInstance().Alert("Vérifier passwords", DialogForms.FrmAlert.enmType.Warning);
                        else
                            SaveDatas();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
                
        }
        void SaveDatas()
        {
            Utilisateurs ag = new Utilisateurs();

            ag.Id = idAgent;
            ag.Noms = nomsTxt.Text;
            ag.Sexe = sexe;
            ag.Adresse = adresseTxt.Text;
            ag.Fonction = fonctionTxt.Text;
            ag.Telephone = phoneTxt.Text;
            ag.Email = emailTxt.Text;
            ag.Pseudo = userTxt.Text;
            ag.PassWord = passConfTxt.Text;
            ag.Photo = photo.Image;

            ag.Enreistrer(ag);

            DynamicClasses.GetInstance().Alert("Utilisateur save", DialogForms.FrmAlert.enmType.Success);

            Clear();

        }

        private void btnParc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();

            try
            {
                if (openDlg.FileName != null)
                {
                    // try to open the file
                    this.photo.Image = Bitmap.FromFile(openDlg.FileName);
                    //this.tbFileName.Text = openDlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue lors du chargement de la photo : " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            nomsTxt.Clear();
            sexe = "";
            rbtnFem.Checked = false;
            rbtnMasc.Checked = false;
            adresseTxt.Clear();
            fonctionTxt.Text = "";
            phoneTxt.Clear();
            emailTxt.Clear();
            userTxt.Clear();
            passTxt.Clear();
            passConfTxt.Clear();
        }
    }
}
