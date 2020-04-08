using CEPGUI.Class;
using CEPGUI.DialogForms;
using DepartementLibrary;
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
    public partial class FrmActivites : Form
    {
        DynamicClasses dn = new DynamicClasses();
        public int id = 0;
        public FrmActivites()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAddActivite frm = new FrmAddActivite();
            frm.ShowDialog();
        }

        private void FrmActivites_Load(object sender, EventArgs e)
        {
            Chargement();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Chargement();
        }
        void Chargement()
        {
            dn.chargeNomsCombo(departTxt, "Departement", "SELECT_DEPARTEMENT");
            dn.chargeNomsCombo(activCombo, "Activite", "SELECT_ACTIVITE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateActivite;
            dateActivite = Convert.ToDateTime(dateTxt.Text);
            try
            {
                OrganiserActivite org = new OrganiserActivite();
                if (activCombo.Text == "" || dateTxt.Text == "" || heureTxt.Text == "" || dateActivite.Date < DateTime.Today)
                {
                    MessageBox.Show("Completer tous les champs obligatoires svp ou vérifier la date.\n N.B: La date ne doit pas etre inférieur à la date d'aujourd'hui", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (dgDepart.Rows.Count > 0)
                    {

                        for (int i = 0; i < (dgDepart.Rows.Count); i++)
                        {
                            org.Id = id;
                            org.RefDepart = Convert.ToInt32(dgDepart[0, i].Value.ToString());
                            org.RefActivite = Convert.ToInt32(dn.retourId(activCombo.Text.Trim(), "@design", "GET_ID_ACTIVITE"));
                            org.Description = descTxt.Text;
                            org.DateActivite = Convert.ToDateTime(dateTxt.Text);
                            org.Heure = heureTxt.Text;
                            org.SaveDatas(org);
                        }
                        dgDepart.Rows.Clear();
                    }
                    else if (dgDepart.Rows.Count == 0)
                    {
                        org.Id = id;
                        org.RefActivite = Convert.ToInt32(dn.retourId(activCombo.Text.Trim(), "@design", "GET_ID_ACTIVITE"));
                        org.Description = descTxt.Text;
                        org.DateActivite = Convert.ToDateTime(dateTxt.Text);
                        org.Heure = heureTxt.Text;
                        org.SaveDatas(org);
                    }
                    dn.Alert("Affectaction reussie", FrmAlert.enmType.Success);
                    dgDepart.Rows.Clear();
                    Initialiser();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Initialiser()
        {
            activCombo.Text = "";
            descTxt.Clear();
            dateTxt.Text = DateTime.Today.ToString();
            heureTxt.Clear();
        }
        private void AddToDataGrid()
        {
            try
            {

                int rowCount;
                if (departTxt.Text == "")
                    MessageBox.Show("Choisissez d'abord un département avant de cliquez ici", "Champs Obligatiore", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                else
                {
                    rowCount = dgDepart.Rows.Count;

                    if (rowCount == 0)
                    {

                        dgDepart.Rows.Add(dn.retourId(departTxt.Text, "@design", "GET_ID_DEPART"), departTxt.Text);
                        RemoveItem();
                    }
                    else if (rowCount > 0)
                    {
                        dgDepart.Rows.Add(dn.retourId(departTxt.Text, "@design", "GET_ID_DEPART"), departTxt.Text);
                        RemoveItem();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        private void RemoveItem()
        {
            departTxt.Items.Remove(departTxt.Text);
            departTxt.Text = "";
        }

        private void activCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void departTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddToDataGrid();
        }
    }
}
