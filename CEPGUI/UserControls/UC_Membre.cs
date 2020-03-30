using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEPGUI.Forms;
using MembreLibrary;
using CEPGUI.Class;

namespace CEPGUI.UserControls
{
    public partial class UC_Membre : UserControl
    {
        DynamicClasses dn = new DynamicClasses();
        public UC_Membre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMembre frm = new FrmMembre();
            frm.ShowDialog();
        }

        private void UC_Membre_Load(object sender, EventArgs e)
        {
            ChargementLoad();
            
        }
        void ChargementLoad()
        {
            SelectDatas(new Membre());
            TotalFidele();
        }
        void TotalFidele()
        {
            lblTotal.Text = dgMembre.Rows.Count.ToString() + " Fidèles";
        }
        void SelectDatas(Membre m)
        {
            dgMembre.DataSource = m.ListOfMembers();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChargementLoad();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            dn.ExportInExcel(dgMembre);
        }

        private void serchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(new Membre());
                TotalFidele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Search(Membre m)
        {
            dgMembre.DataSource = m.Research(serchTxt.Text);
        }
        void doubleclic_grid()
        {
            try
            {
                if (UserSession.GetInstance().Fonction == "Administrateur")
                {
                    FrmMembre frm = new FrmMembre();
                    int i;
                    i = dgMembre.CurrentRow.Index;

                    frm.label6.Text = "Modifier infos du membre";

                    frm.id = Convert.ToInt32(dgMembre["ColId", i].Value.ToString());
                    frm.nomTxt.Text = dgMembre["ColNom", i].Value.ToString();
                    frm.lieuTxt.Text = dgMembre["ColLieu", i].Value.ToString();
                    frm.naissTxt.Text = dgMembre["ColNaiss", i].Value.ToString();
                    frm.baptTxt.Text = dgMembre["ColBapt", i].Value.ToString();
                    frm.pereTxt.Text = dgMembre["ColPere", i].Value.ToString();
                    frm.mereTxt.Text = dgMembre["ColMere", i].Value.ToString();
                    frm.provTxt.Text = dgMembre["ColProv", i].Value.ToString();
                    frm.terrTxt.Text = dgMembre["ColTerr", i].Value.ToString();
                    frm.phoneTxt.Text = dgMembre["ColPhone", i].Value.ToString();
                    frm.pastTxt.Text = dgMembre["ColPast", i].Value.ToString();

                    if (dgMembre["ColSexe", i].Value.ToString() == "M")
                    {
                        frm.rbtnM.Checked = true;
                    }
                    else
                    {
                        frm.rbtnF.Checked = true;
                    }

                    frm.ShowDialog();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void dgMembre_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            doubleclic_grid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmReceptionEnfant frm = new FrmReceptionEnfant();
            frm.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBapteme frm = new FrmBapteme();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMariage frm = new FrmMariage();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmImpression fr = new FrmImpression();
            fr.RegistreMembres();
            fr.ShowDialog();
        }

        private void dgMembre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
