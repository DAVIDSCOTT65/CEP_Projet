using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceptionEnfantLibrary
{
    public class ReceptionEnfant
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public string Noms { get; set; }
        public string Sexe { get; set; }
        public DateTime DateNaissance { get; set; }
        public DateTime DateReception { get; set; }
        public string ProvOrigine { get; set; }
        public string TerrOrigine { get; set; }
        public string Pere { get; set; }
        public string Mere { get; set; }
        public string Pasteur { get; set; }
        public DateTime DateEnregistrement { get; set; }
        public void SaveDatas(ReceptionEnfant m)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_RECEPTION_ENFANT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, m.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@noms", 200, DbType.String, m.Noms));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@sexe", 2, DbType.String, m.Sexe));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@datenaiss", 20, DbType.Date, m.DateNaissance));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@datereception", 20, DbType.Date, m.DateReception));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pere", 200, DbType.String, m.Pere));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@mere", 200, DbType.String, m.Mere));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@provOrigine", 200, DbType.String, m.ProvOrigine));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@terrOrigine", 200, DbType.String, m.TerrOrigine));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pasteur", 50, DbType.String, m.Pasteur));

                cmd.ExecuteNonQuery();

                if (m.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public List<ReceptionEnfant> ListOfEnfantsRecu()
        {
            List<ReceptionEnfant> lst = new List<ReceptionEnfant>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_RECEPTION_ENFANT";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetMembre(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<ReceptionEnfant> Research(string recherche)
        {
            List<ReceptionEnfant> lst = new List<ReceptionEnfant>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM ReceptionEnfant WHERE (Noms LIKE '%" + recherche + "%' OR Noms LIKE '%" + recherche + "' OR Noms LIKE '" + recherche + "%') ORDER By Id DESC";
                //cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetMembre(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private ReceptionEnfant GetMembre(IDataReader dr)
        {
            ReceptionEnfant m = new ReceptionEnfant();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.Noms = dr["Noms"].ToString();
            m.Sexe = dr["Sexe"].ToString();
            m.DateNaissance = Convert.ToDateTime(dr["DateNaissance"].ToString());
            m.DateReception = Convert.ToDateTime(dr["DateReception"].ToString());
            m.Pere = dr["NomPere"].ToString();
            m.Mere = dr["NomMere"].ToString();
            m.ProvOrigine = dr["ProvinceOrigine"].ToString();
            m.TerrOrigine = dr["TerritOrigine"].ToString();
            m.Pasteur = dr["Pasteur"].ToString();
            m.DateEnregistrement = Convert.ToDateTime(dr["DateEnregistrer"].ToString());

            return m;
        }
    }
}
