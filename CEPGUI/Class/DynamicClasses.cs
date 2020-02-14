using CEPGUI.EtatSorties;
using CEPGUI.Forms;
using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPGUI.Class
{
    public class DynamicClasses
    {
        SqlDataReader dr = null;
        SqlDataAdapter dt = null;

        public static DynamicClasses _intance = null;

        public static DynamicClasses GetInstance()
        {
            if (_intance == null)
                _intance = new DynamicClasses();
            return _intance;
        }

        public int loginTest(string nom, string password)
        {
            int count = 0;
            int id = 0;
            string username = "";
            string niveau = "";
            string fonction = "";
            string ability = "";
            string etat = "";
            string maison = "";
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SP_Login";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pseudo", 50, DbType.String, nom));
                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pass", 200, DbType.String, password));

                     
                    IDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        id = Convert.ToInt32(dr["Id"].ToString().Trim());
                        username = dr["noms"].ToString().Trim();
                        fonction = dr["fonction"].ToString().Trim();
                        maison = dr["Eglise"].ToString().Trim();
                        count += 1;
                    }
                    dr.Dispose();
                    if (count == 1)
                    {



                        UserSession.GetInstance().Id = id;
                        UserSession.GetInstance().UserName = username;
                        UserSession.GetInstance().Fonction = fonction;
                        UserSession.GetInstance().Maison = maison;


                    }
                    else
                    {
                        MessageBox.Show("Echec de Connexion.", "Message Serveur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
            return count;
        }
        public void chargeNomsCombo(ComboBox cmb, string nomChamp, string procedure)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                cmb.Items.Clear();

                while (rd.Read())
                {
                    string de = rd[nomChamp].ToString();
                    cmb.Items.Add(de);
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
        }
        public int retourId(string condition,string param, string procedure)
        {
            int identifiant = 0;
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, param, 100, DbType.String, condition));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    identifiant = int.Parse(rd["Id"].ToString());
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return identifiant;
        }
        public string retourCode(string designation)
        {
            string code = "";
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_CODE_ARTICLE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@designation", 100, DbType.String, designation));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    code = rd["Code"].ToString();
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return code;
        }
        public void retourInfoCredit(Label champ1, Label champ2, Label champ3, string valeur)
        {


            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_DETAILS_CREANCE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@valeur", 200, DbType.String, valeur));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {

                    champ1.Text = rd["Noms"].ToString();
                    champ2.Text = rd["Montant"].ToString();
                    champ3.Text = rd["Date_Paiement"].ToString();


                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            //return identifiant;

        }
        public double RetourPrixArticle(string valeur)
        {
            double pv = 0;

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_PVU";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@valeur", 200, DbType.String, valeur));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {

                    pv = Convert.ToDouble(rd["PVu"].ToString());



                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return pv;

        }
        public string RetourUniteArticle(string valeur, Label quantite)
        {
            string unite = "";

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_UNITE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@valeur", 200, DbType.String, valeur));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    if (rd["Unite"] == DBNull.Value || rd["Quantite"] == DBNull.Value)
                    {
                        unite = "Pas d'unité";
                        quantite.Text = "0";
                    }

                    else
                    {
                        unite = rd["Unite"].ToString();
                        quantite.Text = rd["Quantite"].ToString();
                    }


                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return unite;

        }
       
       
        public void retreivePhoto(string valeur, PictureBox photo, string procedure)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = procedure;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@id", 50, DbType.Int32, valeur));

                    dt = new SqlDataAdapter((SqlCommand)cmd);
                    Object resultat = cmd.ExecuteScalar();
                    if (DBNull.Value == (resultat))
                    {
                    }
                    else
                    {
                        //Byte[] buffer = (Byte[])resultat;
                        //MemoryStream ms = new MemoryStream(buffer);
                        //Image image = Image.FromStream(ms);
                        //photo.Image = image;

                        Byte[] buffer = (Byte[])resultat;
                        MemoryStream ms = new MemoryStream(buffer);
                        Image image = Image.FromStream(ms);
                        photo.Image = image;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cette erreur est survenue lors du chargement de la photo : " + ex.Message);
            }

        }
        public void ExportInExcel(DataGridView dg)
        {
            if(dg.Rows.Count <=0)
            {
                MessageBox.Show("Rien à exporter, tableau vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                copyAlltoClipboard(dg);
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
           
        }
        private void copyAlltoClipboard(DataGridView dg)
        {
            //to remove the first blank column from datagridview
            dg.RowHeadersVisible = false;
            dg.SelectAll();
            DataObject dataObj = dg.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        public void RapportDepensesToday()
        {
            try
            {
                FrmImpression frm = new FrmImpression();


                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "GetDepensesToday";
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    SqlDataAdapter dscmd = new SqlDataAdapter((SqlCommand)cmd);
                    dscmd.Fill(ds, "Affichage_Finance_Depense");

                    CR_Depense entree = new CR_Depense();
                    entree.SetDataSource(ds);

                    frm.crystalReportViewer1.ReportSource = entree;
                    frm.crystalReportViewer1.Refresh();
                    frm.rapport = "Depenses";

                    frm.Visible = true;

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }
        public void RapportEntreeToday()
        {
            try
            {
                FrmImpression frm = new FrmImpression();


                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "GetEntreesToday";
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    SqlDataAdapter dscmd = new SqlDataAdapter((SqlCommand)cmd);
                    dscmd.Fill(ds, "Affichage_Finance_Entree");

                    CR_Entree entree = new CR_Entree();
                    entree.SetDataSource(ds);

                    frm.crystalReportViewer1.ReportSource = entree;
                    frm.crystalReportViewer1.Refresh();
                    frm.rapport = "Entrees";

                    frm.Visible = true;

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

    }
}
