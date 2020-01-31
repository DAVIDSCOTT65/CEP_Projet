using CEPGUI.Forms;
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
    }
}
