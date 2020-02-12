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

namespace CEPGUI.Forms
{
    public partial class ConnectUser : Form
    {
        public ConnectUser()
        {
            InitializeComponent();
            //this.ActiveControl = userTxt;
            userTxt.Select();
        }

        private void ConnectUser_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (userTxt.Text == "" || passTxt.Text == "")
                    MessageBox.Show("Veuillez completez tout les champs svp !!!", "Erreur de connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    PubCon.testlog = DynamicClasses.GetInstance().loginTest(userTxt.Text, passTxt.Text);

                    //Envoyer();
                    if (PubCon.testlog == 1)
                    {

                        
                        MessageBox.Show("La connection a reussie !!!", "Message Serveur...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();


                        //frm.Show();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void passTxt_Click(object sender, EventArgs e)
        {
            passTxt.Text = "";
        }

        private void userTxt_Click(object sender, EventArgs e)
        {
            userTxt.Text = "";
        }
    }
}
