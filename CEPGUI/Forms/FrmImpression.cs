using CEPGUI.EtatSorties;
using ManageSingleConnexion;
using ParametreLibrary;
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
    public partial class FrmImpression : Form
    {
        public FrmImpression()
        {
            InitializeComponent();
        }

        private void FrmImpression_Load(object sender, EventArgs e)
        {

        }
        public void RapportDepensesToday()
        {
            try
            {
                


                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "GetDepensesToday";
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    SqlDataAdapter dscmd = new SqlDataAdapter((SqlCommand)cmd);
                    dscmd.Fill(ds, "Affichage_Finance_Depense");

                    CR_Entree entree = new CR_Entree();
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
