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
    public partial class FrmEglise : Form
    {
        public FrmEglise()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UserSession.GetInstance().Fonction == "Administrateur")
                Enregistrer();
            else
                DynamicClasses.GetInstance().Alert("Niveau Admin requis", DialogForms.FrmAlert.enmType.Warning);
        }
        void Enregistrer()
        {
            try
            {
                if (nomTxt.Text == "" || commTxt.Text == "" || accroTxt.Text == "" || addTxt.Text == "" || phoneTxt.Text == "" || phone2.Text == "" || mailTxt.Text == "" || siteTxt.Text == "")
                {
                    DynamicClasses.GetInstance().Alert("Champs vides détectés", DialogForms.FrmAlert.enmType.Error);
                }
                else
                {
                    Eglise m = new Eglise();

                    m.Nom = nomTxt.Text;
                    m.Communaute = commTxt.Text;
                    m.Acronyme = accroTxt.Text;
                    m.Adresse = addTxt.Text;
                    m.Telephone1 = phoneTxt.Text;
                    m.Telephone2 = phone2.Text;
                    m.Mail = mailTxt.Text;
                    m.Logo = logo.Image;
                    m.Siteweb = siteTxt.Text;

                    m.Enregistrer(m);

                    DynamicClasses.GetInstance().Alert("Infos save", DialogForms.FrmAlert.enmType.Success);

                    SelectData(new Eglise());
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void SelectData(Eglise cls)
        {
            dgMaison.DataSource = cls.Details();
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
                    this.logo.Image = Bitmap.FromFile(openDlg.FileName);
                    //this.tbFileName.Text = openDlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue lors du chargement de la photo : " + ex.Message);
            }
        }

        private void FrmEglise_Load(object sender, EventArgs e)
        {
            SelectData(new Eglise());
        }
        void SelectionChanged()
        {
            try
            {
                int i;
                i = dgMaison.CurrentRow.Index;



                nomTxt.Text = dgMaison["ColNom", i].Value.ToString();
                commTxt.Text = dgMaison["ColCom", i].Value.ToString();
                accroTxt.Text = dgMaison["ColAcro", i].Value.ToString();
                addTxt.Text = dgMaison["ColAdd", i].Value.ToString();
                phoneTxt.Text = dgMaison["ColPhone", i].Value.ToString();
                phone2.Text = dgMaison["ColPhone2", i].Value.ToString();
                mailTxt.Text = dgMaison["ColEmail", i].Value.ToString();
                siteTxt.Text = dgMaison["ColSite", i].Value.ToString();
                


                loadLogo(dgMaison["ColId", i].Value.ToString(), logo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        void loadLogo(string id, PictureBox pic)
        {
            DynamicClasses dn = new DynamicClasses();
            dn.retreivePhoto(id, pic, "SELECT_LOGO");
        }

        private void dgMaison_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgMaison_SelectionChanged(object sender, EventArgs e)
        {
            SelectionChanged();
        }
    }
}
