using CEPGUI.Forms;
using CEPGUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public PrincipalForm()
        {
            InitializeComponent();
            Pw = 314;
            Hided = false;
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            PubCon.testFile();
            var form = new ConnectUser();
            form.ShowDialog();
            ChargerUser(new Home());
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

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Hided) button1.Text = "H\nI\nD\nE";
            else button1.Text = "S\nH\nO\nW";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                spanel.Width = spanel.Width + 20;
                centralPanel.Width = centralPanel.Width - 20;
                userPanel.Width = userPanel.Width - 20;
                if(spanel.Width >= Pw)
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
                if (spanel.Width<= 79)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
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
    }
}
