using CEPGUI.Class;
using CommuniqueLibrary;
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
    public partial class FrmAnnonce : Form
    {
        DynamicClasses dn = new DynamicClasses();
        public int id = 0;
        public int idCom = 0;
        public FrmAnnonce()
        {
            InitializeComponent();
        }

        private void FrmAnnonce_Load(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            if (annonceTxt.Text.Trim() == "Rédiger l'annonce ................................................")
            {
                annonceTxt.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDepartement fr = new FrmDepartement();
            fr.ShowDialog();
        }
        private void RemoveItem()
        {
            departCombo.Items.Remove(departCombo.Text);
            departCombo.Text = "";
        }
        private void AddToDataGrid()
        {
            try
            {
                
                int rowCount;
                if (departCombo.Text=="")
                    MessageBox.Show("Choisissez d'abord un département avant de cliquez ici", "Champs Obligatiore", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                else
                {
                    rowCount = dgDepart.Rows.Count;

                    if (rowCount == 0)
                    {
                        
                        dgDepart.Rows.Add(dn.retourId(departCombo.Text, "@design", "GET_ID_DEPART"), departCombo.Text);
                        RemoveItem();
                    }
                    else if (rowCount > 0)
                    {
                        dgDepart.Rows.Add(dn.retourId(departCombo.Text, "@design", "GET_ID_DEPART"), departCombo.Text);
                        RemoveItem();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        void SaveCommuniquer()
        {
            Communiquer com = new Communiquer();
            com.Id = idCom;
            com.DetailsComm = annonceTxt.Text;
            com.DatePublication = Convert.ToDateTime(dateTxt.Text);

            com.SaveDatas(com);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Enregistrer();
        }
        private void Enregistrer()
        {
            
            try
            {
                DateTime datepublication;
                datepublication = Convert.ToDateTime(dateTxt.Text);
                CommuniquerConcerner com = new CommuniquerConcerner();
                if (dateTxt.Text == "" || annonceTxt.Text == "" || annonceTxt.Text.Trim() == "Rédiger l'annonce ................................................" || datepublication.Date < DateTime.Today)
                    MessageBox.Show("Completer tous les champs obligatoires svp ou vérifier la date de publication.\n N.B: La date de publication ne doit pas etre inférieur à la date d'aujourd'hui", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (UserSession.GetInstance().Fonction == "Secrétaire" || UserSession.GetInstance().Fonction == "SA")
                {
                    if (dgDepart.Rows.Count > 0)
                    {
                        SaveCommuniquer();
                        for (int i = 0; i < (dgDepart.Rows.Count); i++)
                        {
                            com.Id = id;
                            com.RefDepart = Convert.ToInt32(dgDepart[0, i].Value.ToString());
                            com.RefComm = Convert.ToInt32(dn.retourId(departCombo.Text.Trim(), "@design", "GET_ID_COMMUNIQUE"));
                            com.SaveDatas(com);
                        }
                        dgDepart.Rows.Clear();
                    }
                    else if (dgDepart.Rows.Count == 0)
                    {
                        SaveCommuniquer();
                        com.Id = id;
                        com.RefComm = Convert.ToInt32(dn.retourId(departCombo.Text.Trim(), "@design", "GET_ID_COMMUNIQUE"));
                        com.SaveDatas(com);
                    }
                    //MessageBox.Show("Annonce enregistrer avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgDepart.Rows.Clear();
                    annonceTxt.Text = "Rédiger l'annonce ................................................";
                    dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
                    dn.Alert("Annonce ajouter", DialogForms.FrmAlert.enmType.Success);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void departCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddToDataGrid();
        }

        private void annonceTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
