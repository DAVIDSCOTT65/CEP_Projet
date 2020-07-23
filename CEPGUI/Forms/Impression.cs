using CEPGUI.EtatSorties;
using ManageSingleConnexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPGUI.Forms
{
    public partial class Impression : Form
    {
        public Impression()
        {
            InitializeComponent();
        }

        private void Impression_Load(object sender, EventArgs e)
        {
            RegistreMembres();
        }
        public void RegistreMembres()
        {
            try
            {


                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "GetRegistreMembres";
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    SqlDataAdapter dscmd = new SqlDataAdapter((SqlCommand)cmd);
                    dscmd.Fill(ds, "Affichage_Membres");

                    CR_Test entree = new CR_Test();
                    entree.SetDataSource(ds);

                    crystalReportViewer1.ReportSource = entree;
                    crystalReportViewer1.Refresh();




                }




            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
    }
}
