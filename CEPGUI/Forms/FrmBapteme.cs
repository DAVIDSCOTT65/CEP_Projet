using BaptemeLibrary;
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
    public partial class FrmBapteme : Form
    {
        DynamicClasses dn = new DynamicClasses();
        public int idPrev = 0;
        public int idConf = 0;
        public FrmBapteme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void doubleclic_grid()
        {
            try
            {
                if (UserSession.GetInstance().Fonction == "Administrateur")
                {
                   
                    int i;
                    i = dgBapt.CurrentRow.Index;

                    

                    idPrev= Convert.ToInt32(dgBapt["ColId", i].Value.ToString());
                    recptTxt.Text= dgBapt["ColDatePrev", i].Value.ToString();
                    membreCombo.Text = dgBapt["ColFidele", i].Value.ToString();
                    lieuTxt.Text = dgBapt["ColLieuBapt", i].Value.ToString();
                    pastTxt.Text= dgBapt["ColPasteur", i].Value.ToString();
                    confTxt.Text = dgBapt["ColDatePrev", i].Value.ToString();
                    lblConf.Text = dgBapt["ColFidele", i].Value.ToString();
                    confBtn.Enabled = true;

                    
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(membreCombo, "Noms", "SELECT_MEMBRE");
            ChargementDatas(new PrevisionBapteme());
        }
        void ChargementDatas(PrevisionBapteme prev)
        {
            dgBapt.DataSource = prev.ListOfPrevisions();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FrmMembre frm = new FrmMembre();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(membreCombo, "Noms", "SELECT_MEMBRE");
            ChargementDatas(new PrevisionBapteme());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmBaptemeSave frm = new FrmBaptemeSave();
            frm.ShowDialog();
        }

        private void recptTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void recptTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dn.RetourDatasBapteme(recptTxt.Text, lieuTxt, pastTxt);
            }
            catch (Exception)
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime datecelebr;
                datecelebr = Convert.ToDateTime(recptTxt.Text);

                PrevisionBapteme prev = new PrevisionBapteme();

                if(datecelebr<DateTime.Today || membreCombo.Text=="")
                {
                    MessageBox.Show("Champs vide ou date inférieur", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (UserSession.GetInstance().Fonction == "Secrétaire" || UserSession.GetInstance().Fonction == "SA")
                {
                    prev.Id = idPrev;
                    prev.RefMembre = dn.retourId(membreCombo.Text, "@design", "GET_ID_MEMBRE");
                    prev.RefBapteme = dn.retourIdWithDate(recptTxt.Text, "@design", "GET_ID_BAPTEME");

                    prev.SaveDatas(prev);

                    MessageBox.Show(membreCombo.Text + " ajouter à la liste de bapteme du " + recptTxt.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Initialiser();

                    ChargementDatas(new PrevisionBapteme());
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Initialiser()
        {
            idPrev = 0;
            idConf = 0;
            membreCombo.Items.Remove(membreCombo.Text);
            //dn.chargeNomsCombo(membreCombo, "Noms", "SELECT_MEMBRE");
        }

        private void dgBapt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            doubleclic_grid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime datecelebr;
                datecelebr = Convert.ToDateTime(confTxt.Text);
                

                if (datecelebr > DateTime.Today || confTxt.Text== "  /  /" || idPrev==0)
                {
                    MessageBox.Show("Impossible de confirmer ce bapteme, la date n'est pas encore arriver", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    confTxt.Text = recptTxt.Text;
                }
                else if (UserSession.GetInstance().Fonction == "Secrétaire" || UserSession.GetInstance().Fonction == "SA")
                {
                    Baptiser b = new Baptiser();
                    b.Id = idConf;
                    b.DateBapteme = Convert.ToDateTime(confTxt.Text);
                    b.RefPrevision = idPrev;

                    b.SaveDatas(b);

                    MessageBox.Show(membreCombo.Text + " baptisé(e) le " + confTxt.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    InitialiserConfirmation();

                    ChargementDatas(new PrevisionBapteme());
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void InitialiserConfirmation()
        {
            idPrev = 0;
            confTxt.Clear();
            confBtn.Enabled = false;

        }

        private void dgBapt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            Research(new PrevisionBapteme());
        }
        void Research(PrevisionBapteme prev)
        {
            try
            {
                dgBapt.DataSource = prev.Research(serchTxt.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
