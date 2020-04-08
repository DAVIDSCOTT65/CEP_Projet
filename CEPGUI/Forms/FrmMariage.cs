using CEPGUI.Class;
using ManageSingleConnexion;
using MariageLibrary;
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
    public partial class FrmMariage : Form
    {
        PrevisionMariage pre = new PrevisionMariage();
        DynamicClasses dn = new DynamicClasses();
        public int idParrainage = 0;
        public int idPrevision = 0;
        public FrmMariage()
        {
            InitializeComponent();
        }
        void doubleclic_grid()
        {
            try
            {
                if (UserSession.GetInstance().Fonction == "Administrateur")
                {
                    FrmFaireMariage frm = new FrmFaireMariage();
                    int i;
                    i = dgMariage.CurrentRow.Index;



                    frm.refprev = Convert.ToInt32(dgMariage["ColId", i].Value.ToString());
                    frm.lblConjoint.Text = dgMariage["ColConjoint", i].Value.ToString();
                    frm.lblParrain.Text = dgMariage["ColParrain", i].Value.ToString();
                    frm.dateTxt.Text = dgMariage["ColDate", i].Value.ToString();
                    frm.pastTxt.Text = dgMariage["ColPasteur", i].Value.ToString();

                    frm.ShowDialog();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        private void FrmMariage_Load(object sender, EventArgs e)
        {
            Chargement();
        }
        void Chargement()
        {
            try
            {
                dn.chargeNomsCombo(cmbDate, "DatePasteur", "SELECT_DATE_PASTEUR");

                pre.AutoCompleteMode("AUTO_COMPLETE_CONJOINT", conjointTxt);
                pre.AutoCompleteMode("AUTO_COMPLETE_CONJOINTE", conjointeTxt);
                pre.AutoCompleteMode("AUTO_COMPLETE_MARRAINE", marraineTxt);
                pre.AutoCompleteMode("AUTO_COMPLETE_PARRAIN", parrainTxt);
                cmbDate.SelectedIndex = 0;
            }
            catch (Exception)
            {

                
            }
        }
        void SelectData(PrevisionMariage prev)
        {
            dgMariage.DataSource = prev.ListOfPrevisions(cmbDate.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            FrmAddMariage fr = new FrmAddMariage();
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(conjointeTxt.Text=="" || conjointTxt.Text=="" || conjointeTxt.Text == "Conjointe" || conjointTxt.Text == "Conjoint" || parrainTxt.Text=="" || marraineTxt.Text=="" || parrainTxt.Text == "Parrain" || marraineTxt.Text == "Marraine" || cmbDate.Text=="")
                {
                    dn.Alert("Champs vides détectés", DialogForms.FrmAlert.enmType.Error);
                }
                else
                {
                    if(conjointTxt.Text==parrainTxt.Text || conjointTxt.Text==marraineTxt.Text || conjointeTxt.Text== parrainTxt.Text || conjointeTxt.Text == marraineTxt.Text)
                    {
                        MessageBox.Show("Impossible d'enregistrer le meme nom pour les conjoints et les parrainage");
                    }
                    else
                    {
                        EnregistreParrainage();
                    }
                       
                    
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Initialise()
        {
            conjointTxt.Text = "Conjoint";
            conjointeTxt.Text = "Conjointe";
            parrainTxt.Text = "Parain";
            marraineTxt.Text = "Marraine";
            
        }
        void EnregistrerPrevision()
        {
            PrevisionMariage pre = new PrevisionMariage();

            pre.Id = idPrevision;
            pre.RefMariage = dn.retourId(cmbDate.Text, "@design", "GET_ID_MARIAGE");
            pre.RefConjoint = dn.retourId(conjointTxt.Text, "@design", "GET_ID_MEMBRE");
            pre.RefConjointe = dn.retourId(conjointeTxt.Text, "@design", "GET_ID_MEMBRE");
            //pre.RefParrainage = dn.retourIdParrainnage(parrainTxt.Text.Trim(), marraineTxt.Text.Trim(), "GET_ID_PARRAINNAGE");
            pre.RefParrainage = idParrainage;
            pre.Parrain = parrainTxt.Text;
            pre.Marraine = marraineTxt.Text;

            pre.SaveDatas(pre);

            MessageBox.Show("Couple " + conjointTxt.Text + " et " + conjointeTxt.Text + " ajouter à la liste de mariage du " + cmbDate.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Initialise();
        }
        void EnregistreParrainage()
        {
            if(parrainTxt.Text==marraineTxt.Text)
            {
                MessageBox.Show("Impossible d'enregistrer le meme nom pour parrain et marraine");
            }
            else
            {
                //Parrainage p = new Parrainage();

                //p.Id = idParrainage;
                //p.Parrain = parrainTxt.Text;
                //p.Marraine = marraineTxt.Text;

                //p.SaveDatas(p);

                //Enregistrement Prevision Mariage
                EnregistrerPrevision();
            }
            
        }

        private void conjointTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void conjointTxt_MouseClick(object sender, MouseEventArgs e)
        {
            conjointTxt.Text = "";
        }

        private void conjointeTxt_MouseClick(object sender, MouseEventArgs e)
        {
            conjointeTxt.Text = "";
        }

        private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectData(new PrevisionMariage());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(cmbDate, "DatePasteur", "SELECT_DATE_PASTEUR");
            SelectData(new PrevisionMariage());
        }

        private void marraineTxt_TextChanged(object sender, EventArgs e)
        {
            //parrainTxt.Text = dn.retourParrain(marraineTxt.Text.Trim());
        }

        private void parrainTxt_MouseClick(object sender, MouseEventArgs e)
        {
            parrainTxt.Text = "";
        }

        private void marraineTxt_MouseClick(object sender, MouseEventArgs e)
        {
            marraineTxt.Text = "";
        }

        private void dgMariage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            doubleclic_grid();
        }

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            Search(new PrevisionMariage());
        }
        void Search(PrevisionMariage prev)
        {
            try
            {
                dgMariage.DataSource = prev.Research(serchTxt.Text,cmbDate.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void conjointeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void parrainTxt_TextChanged(object sender, EventArgs e)
        {
            marraineTxt.Text=dn.retourMarraine(parrainTxt.Text.Trim());
            
        }

        private void parrainTxt_Validated(object sender, EventArgs e)
        {
            //marraineTxt.Enabled = false;
        }
    }
}
