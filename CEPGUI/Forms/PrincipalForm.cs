using CEPGUI.Class;
using CEPGUI.Forms;
using CEPGUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPGUI
{
    public partial class PrincipalForm : Form
    {
        int Pw;
        bool Hided;
        Home h = new Home();
        public PrincipalForm()
        {
            InitializeComponent();
            Pw = 314;
            Hided = true;
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

            LoadForm();
            
        }
        void LoadForm()
        {
            try
            {
                PubCon.testFile();
                var form = new ConnectUser();
                form.ShowDialog();
                loadPhoto(UserSession.GetInstance().Id.ToString(), avatarPic);
                lblNom.Text = UserSession.GetInstance().UserName;
                lblFonction.Text = UserSession.GetInstance().Fonction;
                ChargerUser(new Home());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur de chargement : \n" + ex.Message);
            }
        }
        void loadPhoto(string id, PictureBox pic)
        {
            DynamicClasses dn = new DynamicClasses();
            dn.retreivePhoto(id, pic, "SELECT_PHOTO");
        }
        public void ChargerUser(UserControl userc)
        {
            try
            {
                userc.Dock = DockStyle.Fill;
                centralPanel.Controls.Clear();
                centralPanel.Controls.Add(userc);

            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue lors du chargement : " + ex.Message);
            }
        }
        void Slide()
        {
            try
            {
                
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Slide();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Hided)
                {
                    spanel.Width = spanel.Width + 20;
                    centralPanel.Width = centralPanel.Width - 20;
                    userPanel.Width = userPanel.Width - 20;
                    if (spanel.Width >= Pw)
                    {
                        timer1.Stop();
                        Hided = false;
                        this.Refresh();
                    }
                }
                else
                {
                    spanel.Width = spanel.Width - 20;
                    centralPanel.Width = centralPanel.Width + 20;
                    userPanel.Width = userPanel.Width + 20;
                    if (spanel.Width <= 54)
                    {
                        timer1.Stop();
                        Hided = true;
                        this.Refresh();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChargerUser(new UC_Entrees());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChargerUser(new UC_Depense());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChargerUser(new UC_Membre());
            //h.timer1.Stop();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ChargerUser(new Home());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChargerUser(new UC_Departements());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChargerUser(new UC_Communique());
        }

        private void spanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChargerUser(new UC_Activite());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChargerUser(new UC_Bapteme());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChargerUser(new UC_Mariage());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ChargerUser(new UC_Reception());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ChargerUser(new UC_Utilisateurs());
        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmBackRestore fr = new FrmBackRestore();
            fr.Show();
        }
    }
}
