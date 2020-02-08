using CEPGUI.Class;
using MembreLibrary;
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
    public partial class AffectactionDepartement : Form
    {
        DynamicClasses dn = new DynamicClasses();
        public int id = 0;
        public AffectactionDepartement()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AffectactionDepartement_Load(object sender, EventArgs e)
        {
            ChargementDatas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnregistrerData();
        }
        void EnregistrerData()
        {
            try
            {
                if(id<0 || departCombo.Text=="" || membreCombo.Text=="")
                {
                    MessageBox.Show("Completer tous les champs svp", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Appartenir ap = new Appartenir();

                    ap.Id = id;
                    ap.RefDepartement = dn.retourId(departCombo.Text, "@design", "GET_ID_DEPART");
                    ap.RefMembre = dn.retourId(membreCombo.Text, "@design", "GET_ID_MEMBRE");

                    ap.SaveDatas(ap);

                    Initialise();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Initialise()
        {
            id = 0;
            departCombo.Text = "";
            membreCombo.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDepartement frm = new FrmDepartement();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMembre frm = new FrmMembre();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChargementDatas();
        }
        void ChargementDatas()
        {
            dn.chargeNomsCombo(departCombo, "Departement", "SELECT_DEPARTEMENT");
            dn.chargeNomsCombo(membreCombo, "Noms", "SELECT_NOMS_MEMBRE");
        }
    }
}
