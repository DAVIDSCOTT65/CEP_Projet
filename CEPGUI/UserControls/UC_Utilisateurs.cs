using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitiesLibrary;
using CEPGUI.Class;
using CEPGUI.Forms;

namespace CEPGUI.UserControls
{
    public partial class UC_Utilisateurs : UserControl
    {
        public UC_Utilisateurs()
        {
            InitializeComponent();
        }

        private void UC_Utilisateurs_Load(object sender, EventArgs e)
        {
            SelectData(new Utilisateurs());
        }
        void SelectData(Utilisateurs u)
        {
            dgAgent.DataSource = u.AllUser();
        }
        void doubleclic_grid()
        {
            try
            {
                if (UserSession.GetInstance().Fonction == "Administrateur")
                {
                    FrmAgent frm = new FrmAgent();
                    int i;
                    i = dgAgent.CurrentRow.Index;

                    frm.label1.Text = "Modification info d'un agent";
                    frm.idAgent = Convert.ToInt32(dgAgent["ColId", i].Value.ToString());
                    frm.nomsTxt.Text = dgAgent["ColNom", i].Value.ToString();
                    frm.adresseTxt.Text = dgAgent["ColAdresse", i].Value.ToString();
                    frm.emailTxt.Text = dgAgent["ColEmail", i].Value.ToString();
                    frm.fonctionTxt.Text = dgAgent["ColFonction", i].Value.ToString();
                    frm.userTxt.Text = dgAgent["ColPseudo", i].Value.ToString();
                    frm.fonctionTxt.ReadOnly = true;
                    frm.phoneTxt.Text = dgAgent["ColContact", i].Value.ToString();

                    if (dgAgent["ColSex", i].Value.ToString() == "M")
                    {
                        frm.rbtnMasc.Checked = true;
                    }
                    else
                    {
                        frm.rbtnFem.Checked = true;
                    }



                    loadPhoto(dgAgent["ColId", i].Value.ToString(), frm.photo);

                    frm.ShowDialog();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        void loadPhoto(string id, PictureBox pic)
        {
            DynamicClasses dn = new DynamicClasses();
            dn.retreivePhoto(id, pic, "SELECT_PHOTO");
        }

        private void dgAgent_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FrmAgent ag = new FrmAgent();

            ag.ShowDialog();
        }

        private void dgAgent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            doubleclic_grid();
        }

        private void dgAgent_SelectionChanged(object sender, EventArgs e)
        {
            clic_grid();
        }
        void clic_grid()
        {
            try
            {
                int i;
                i = dgAgent.CurrentRow.Index;


                //txtid.Text = dataGridView1["ColId", i].Value.ToString();
                lblNom.Text = dgAgent["ColNom", i].Value.ToString();
                lblPhone.Text = dgAgent["ColContact", i].Value.ToString();
                lblMail.Text = dgAgent["ColEmail", i].Value.ToString();
                label24.Text = dgAgent["ColSex", i].Value.ToString();
                label22.Text = dgAgent["ColAdresse", i].Value.ToString();
                label21.Text = dgAgent["ColPseudo", i].Value.ToString();
                label20.Text = dgAgent["ColPassword", i].Value.ToString();
                label17.Text = dgAgent["ColFonction", i].Value.ToString();

                loadPhoto(dgAgent["ColId", i].Value.ToString(), pictureBox2);

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
    }
}
