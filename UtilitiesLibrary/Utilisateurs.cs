using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitiesLibrary
{
    public class Utilisateurs
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public string Noms { get; set; }
        public string Sexe { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Fonction { get; set; }
        public string Pseudo { get; set; }
        public string PassWord { get; set; }
        public Image Photo { get; set; }
        private byte[] ConverttoByteImage(Image img)
        {
            MemoryStream ms = new MemoryStream();
            Bitmap bmpImage = new Bitmap(img);
            byte[] bytImage;
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            bytImage = ms.ToArray();
            ms.Close();
            return bytImage;
        }
        public int NewId()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(Id) AS LastId FROM Utilisateur";

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["LastId"] == DBNull.Value)
                        Id = 1;
                    else
                        Id = Convert.ToInt32(dr["LastId"].ToString()) + 1;
                }
                dr.Dispose();
            }

            return Id;
        }
        public void Enreistrer(Utilisateurs det)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_AGENT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, det.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@noms", 100, DbType.String, det.Noms));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@sexe", 1, DbType.String, det.Sexe));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@adresse", 100, DbType.String, det.Adresse));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@contact", 20, DbType.String, det.Telephone));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@email", 100, DbType.String, det.Email));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@fonction", 50, DbType.String, det.Fonction));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pseudo", 20, DbType.String, det.Pseudo));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@password", 100, DbType.String, det.PassWord));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@photo", int.MaxValue, DbType.Binary, ConverttoByteImage(det.Photo)));

                cmd.ExecuteNonQuery();

                if (det.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<Utilisateurs> AllUser()
        {
            List<Utilisateurs> lst = new List<Utilisateurs>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_UTILISATEURS";
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GedUser(dr));
                }
                dr.Dispose();
            }


            return lst;
        }
        private Utilisateurs GedUser(IDataReader dr)
        {
            Utilisateurs u = new Utilisateurs();

            i = i + 1;

            u.Num = i;
            u.Id = Convert.ToInt32(dr["Id"].ToString());
            u.Noms = dr["Noms"].ToString();
            u.Sexe = dr["Sexe"].ToString();
            u.Adresse = dr["Adresse"].ToString();
            u.Telephone = dr["Telephone"].ToString();
            u.Email = dr["Email"].ToString();
            u.Fonction = dr["Fonction"].ToString();
            u.Pseudo = dr["Pseudo"].ToString();
            u.PassWord = dr["PassWords"].ToString();

            return u;
        }
    }
}
