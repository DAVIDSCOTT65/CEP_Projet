using CEPGUI.Class;
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
using UtilitiesLibrary;

namespace CEPGUI.Forms
{
    public partial class FrmBackRestore : Form
    {
        DatabaseBackupOrRestor bd = new DatabaseBackupOrRestor();
        public int backUp = 0;
        public FrmBackRestore()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                btnParcourir.Enabled = false;
                btnSauvegarde.Enabled = true;
            }
            else
            {
                btnParcourir.Enabled = true;
                btnSauvegarde.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked==true)
            {
                btnSauvegarde.Enabled = false;
                btnParcourir.Enabled = true;
            }
            else
            {
                btnSauvegarde.Enabled = true;
                btnParcourir.Enabled = false;
            }
            
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    personalizePath.Text = dlg.SelectedPath;
                    btnSauvegarde.Enabled = true;
                }
            }
            catch (Exception)
            { }
        }

        private void btnSauvegarde_Click(object sender, EventArgs e)
        {
            try
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();

                //con = new SqlConnection(ap.chemin);
                string database = ImplementeConnexion.Instance.Conn.Database.ToString();

                if (bd.getBackupPath(radioButton3, personalizePath) == string.Empty)
                {
                    MessageBox.Show("Veuillez selectionner d'abord un emplacement s.v.p.!");
                }
                else
                {

                    BackUpDefault();
                    MessageBox.Show("Sauvegarde effectué avec succés", "Confirmation Sauvegarde");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public void BackUpDefault()
        {
            string database = ImplementeConnexion.Instance.Conn.Database.ToString();
            string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + bd.getBackupPath(radioButton3, personalizePath) + "\\" + database + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

            using (SqlCommand command = new SqlCommand(cmd, (SqlConnection)ImplementeConnexion.Instance.Conn))
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();

                command.ExecuteNonQuery();
                ImplementeConnexion.Instance.Conn.Close();



                backUp = 1;
            }
        }

        private void FrmBackRestore_Load(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "SQL SERVER database backup files|*.bak";
                dlg.Title = "Database restore";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    dbPath.Text = dlg.FileName;
                    btnreset.Enabled = true;
                }
                btnreset.Enabled = true;
            }
            catch (Exception)
            {


            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            try
            {
                BackUpDefault();
                RestoreDatas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void RestoreDatas()
        {
            if (UserSession.GetInstance().Fonction == "Administrateur" || UserSession.GetInstance().Fonction == "SA")
            {
                if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();

                string database = ImplementeConnexion.Instance.Conn.Database.ToString();

                try
                {
                    string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand bu2 = new SqlCommand(sqlStmt2, (SqlConnection)ImplementeConnexion.Instance.Conn);
                    bu2.ExecuteNonQuery();

                    string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + dbPath.Text + "'WITH REPLACE;";
                    SqlCommand bu3 = new SqlCommand(sqlStmt3, (SqlConnection)ImplementeConnexion.Instance.Conn);
                    bu3.ExecuteNonQuery();

                    string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    SqlCommand bu4 = new SqlCommand(sqlStmt4, (SqlConnection)ImplementeConnexion.Instance.Conn);
                    bu4.ExecuteNonQuery();

                    MessageBox.Show("Database restoration done successefully", "Confirmation de restauration");
                    //con.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erreur de " + exc);
                }
                finally
                {
                    ImplementeConnexion.Instance.Conn.Close();
                }
            }
            else
                MessageBox.Show("Vous n'etes pas autoriser d'effectuer cette opération", "Attention !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }
    }
}
