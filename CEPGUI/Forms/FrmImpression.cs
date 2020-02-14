using CEPGUI.Class;
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
        DynamicClasses dn = new DynamicClasses();
        public string rapport = "";
        public FrmImpression()
        {
            InitializeComponent();
        }

        private void FrmImpression_Load(object sender, EventArgs e)
        {
            dn.chargeNomsCombo(monthCombo, "Mois", "SELECT_MONTH");
            dn.chargeNomsCombo(yearCombo, "Annee", "SELECT_YEAR");
        }
        public void RapportEntreeMonth(string month,int year)
        {
            try
            {
                FrmImpression frm = new FrmImpression();


                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "GetEntreesMonth";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@month", 50, DbType.String, month));
                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@year", 50, DbType.Int32, year));

                    DataSet ds = new DataSet();
                    SqlDataAdapter dscmd = new SqlDataAdapter((SqlCommand)cmd);
                    dscmd.Fill(ds, "Affichage_Finance_Entree");

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
        public void RapportDepensesMonth(string month, int year)
        {
            try
            {
                


                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "GetDepensesMonth";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@month", 50, DbType.String, month));
                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@year", 50, DbType.Int32, year));

                    DataSet ds = new DataSet();
                    SqlDataAdapter dscmd = new SqlDataAdapter((SqlCommand)cmd);
                    dscmd.Fill(ds, "Affichage_Finance_Depense");

                    CR_Depense entree = new CR_Depense();
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

        private void monthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yearCombo.Text != "")
            {
                switch (rapport)
                {
                    case "Entrees":
                        RapportEntreeMonth(monthCombo.Text, Convert.ToInt32(yearCombo.Text.Trim()));
                    
                        break;
                    case "Depenses":
                        RapportDepensesMonth(monthCombo.Text, Convert.ToInt32(yearCombo.Text.Trim()));
                        break;
                }
            }
                
        }

        private void yearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monthCombo.Text != "")
            {
                switch (rapport)
                {
                    case "Entrees":
                        RapportEntreeMonth(monthCombo.Text, Convert.ToInt32(yearCombo.Text.Trim()));

                        break;
                    case "Depenses":
                        RapportDepensesMonth(monthCombo.Text, Convert.ToInt32(yearCombo.Text.Trim()));
                        break;
                }
            }
        }
    }
}
