using CEPGUI.Class;
using CommuniqueLibrary;
using DepartementLibrary;
using MembreLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPGUI.Forms
{
    public partial class FrmSms : Form
    {
        ClsSms sms = new ClsSms();
        DynamicClasses dn = new DynamicClasses();
        Communiquer c = new Communiquer();
        Activites a = new Activites();
        bool check;
        public FrmSms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestModem();
            if (txtMessage.Text != "" && check==true)
            {
                if (radioNone.Checked == true)
                {
                    if (txtPhone.Text != "")
                    {
                        SendSms(txtPhone.Text.Trim());
                        dn.Alert("SMS  send", DialogForms.FrmAlert.enmType.Success);
                    }   
                    else
                        dn.Alert("Pas de num", DialogForms.FrmAlert.enmType.Error);
                }
                else if (radioActivite.Checked==true || radioAnnonce.Checked==true)
                {
                    
                    for (int i = 0; i < dgMembre.RowCount; i++)
                    {
                        if(i > 0)
                            check = sms.connetport();
                        SendSms(dgMembre[11, i].Value.ToString());
                        dn.Alert("SMS "+ i +" send", DialogForms.FrmAlert.enmType.Success);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vérifier qu'il y a un message à envoyer.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void TestModem()
        {
            try
            {
                if (txtPort.Text == "")
                {
                    MessageBox.Show("Vérifier que le modem est bien branché ou changer de port.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sms.com = txtPort.Text.Substring(0, 4);
                    check = sms.connetport();
                    statusTxt.Text = "Sending...\n";
                    Thread.Sleep(1000);
                    statusTxt.Text += "\rConnecton Status " + check + "\n";
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SendSms(string phone)
        {
            try
            {
                sms.sendsms(txtMessage.Text.Trim(), phone);
                statusTxt.Text += "\nSuccessfully !!! ";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmSms_Load(object sender, EventArgs e)
        {
            //GetAllPorts();
            timer1.Start();
            dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
        }
        public void GetAllPorts()
        {
            //string MODEMS = "";
            

            try
            {
                //combo.Items.Clear();

                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_POTSModem ");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if ((string)queryObj["Status"] == "OK")
                    {

                        txtPort.Items.Add(queryObj["AttachedTo"] + " - " + System.Convert.ToString(queryObj["Description"]));
                    }
                    if (txtPort.Items.Count > 0)
                    {
                        txtPort.SelectedIndex = 0;
                        txtPort.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la requette", "Erreur de" + ex.Message);
                
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioAnnonce_CheckedChanged(object sender, EventArgs e)
        {
            
            txtPhone.Enabled = false;
            departCombo.Enabled = true;
            if (departCombo.Text != "" && radioAnnonce.Checked==true)
            {
                ChargementDataGrid(new Membre());

                if (radioActivite.Checked == true)
                {
                    //On affiche l'activité pour le departement de la semaine
                    dgMessage.DataSource = a.ListOfActivites(departCombo.Text);
                    CountMessage();
                }
                else if (radioAnnonce.Checked == true)
                {
                    //On affiche l'annonce pour le departement de la semaine
                    dgMessage.DataSource = c.ListOfAnnonces(departCombo.Text);
                    CountMessage();
                }
                else
                {
                    lblSms.Text = "0 Messages";
                }
            }
        }
        void ChargementDataGrid(Membre m)
        {
            try
            {
                dgMembre.DataSource = m.ListOfMembersAndDepartment(departCombo.Text);
                CountContact();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur lors du chargement de la table : " + ex.Message);
            }

        }
        void CountContact()
        {
            lblContact.Text = dgMembre.Rows.Count.ToString() + " Contacts";
        }
        void CountMessage()
        {
            lblSms.Text = dgMessage.Rows.Count.ToString() + " Messages";
        }
        private void radioActivite_CheckedChanged(object sender, EventArgs e)
        {

            txtPhone.Enabled = false;
            departCombo.Enabled = true;
            if (departCombo.Text != "" && radioActivite.Checked==true)
            {
                ChargementDataGrid(new Membre());

                if (radioActivite.Checked == true)
                {
                    //On affiche l'activité pour le departement de la semaine
                    dgMessage.DataSource = a.ListOfActivites(departCombo.Text);
                    CountMessage();
                }
                else if (radioAnnonce.Checked == true)
                {
                    //On affiche l'annonce pour le departement de la semaine
                    dgMessage.DataSource = c.ListOfAnnonces(departCombo.Text);
                    CountMessage();
                }
                else
                {
                    lblSms.Text = "0 Messages";
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNone.Checked == true)
            {
                txtPhone.Enabled = true;
                departCombo.SelectedIndex = -1;
                departCombo.Enabled = false;
            }
        }

        private void departCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departCombo.Text != "")
            {
                ChargementDataGrid(new Membre());

                if (radioActivite.Checked==true)
                {
                    //On affiche l'activité pour le departement de la semaine
                    dgMessage.DataSource = a.ListOfActivites(departCombo.Text);
                    CountMessage();
                }
                else if(radioAnnonce.Checked==true)
                {
                    //On affiche l'annonce pour le departement de la semaine
                    dgMessage.DataSource = c.ListOfAnnonces(departCombo.Text);
                    CountMessage();
                }
                else
                {
                    lblSms.Text = "0 Messages";
                }
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetAllPorts();
        }

        private void dgMessage_SelectionChanged(object sender, EventArgs e)
        {
            Clic_grid();
        }
        void Clic_grid()
        {
            try
            {
                int i;
                i = dgMessage.CurrentRow.Index;


                //txtid.Text = dataGridView1["ColId", i].Value.ToString();
                txtMessage.Text = dgMessage["ColSms", i].Value.ToString();
                if (dgMessage["ColSms", i].Value.ToString() == "")
                    txtMessage.Text = "";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
    }
}
