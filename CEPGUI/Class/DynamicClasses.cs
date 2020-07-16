using CEPGUI.DialogForms;
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
        public void Alert(string msg, FrmAlert.enmType type)
        {
            FrmAlert frm = new FrmAlert();
            frm.ShowAlert(msg, type);
        }
        public DataTable QueryAsDataTable(string sql)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, (SqlConnection)ImplementeConnexion.Instance.Conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
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
            try
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
            catch (Exception ex)
            {

                MessageBox.Show("Une exception est survenue : " + ex.Message);
            }
        }
        public int retourId(string condition,string param, string procedure)
        {
            int identifiant = 0;
            try
            {
                
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
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Une exception est survenue : " + ex.Message);
            }
            return identifiant;
        }
        public string retourMarraine(string condition)
        {
            string identifiant = "";
            try
            {
                
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT_MARRAINE";

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@noms", 100, DbType.String, condition));

                    IDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        identifiant = rd["NomsMarraine"].ToString();
                    }
                    rd.Close();
                    rd.Dispose();
                    cmd.Dispose();
                }
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Une exception est survenue : " + ex.Message);
            }
            return identifiant;
        }
        public string retourParrain(string condition)
        {
            string identifiant = "";
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_PARRAIN";

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@noms", 100, DbType.String, condition));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    identifiant = rd["NomsParrain"].ToString();
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
            return identifiant;
        }
        public int retourIdParrainnage(string parrain, string marraine, string procedure)
        {
            int identifiant = 0;
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@parrain", 100, DbType.String, parrain));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@marraine", 100, DbType.String, marraine));

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
        public int retourIdWithDate(string condition, string param, string procedure)
        {
            int identifiant = 0;
            try
            {
                
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = procedure;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, param, 100, DbType.Date, condition));

                    IDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        identifiant = int.Parse(rd["Id"].ToString());
                    }
                    rd.Close();
                    rd.Dispose();
                    cmd.Dispose();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return identifiant;
        }
        public void RetourDatasBapteme(string condition,TextBox champ1, TextBox champ2)
        {

            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT_DATAS_BAPTEMES";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@date", 100, DbType.Date, condition));

                    IDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        champ1.Text = rd["Lieu"].ToString();
                        champ2.Text = rd["Pasteur"].ToString();
                    }
                    rd.Close();
                    rd.Dispose();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
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
            try
            {
                if (dg.Rows.Count <= 0)
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
            catch (Exception ex)
            {

                MessageBox.Show("Erreur lors de l'export en excel : \n" + ex.Message);
            }
           
        }
        private void copyAlltoClipboard(DataGridView dg)
        {
            try
            {
                //to remove the first blank column from datagridview
                dg.RowHeadersVisible = false;
                dg.SelectAll();
                DataObject dataObj = dg.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
