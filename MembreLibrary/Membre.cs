using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MembreLibrary
{
    public class Membre
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public string Noms { get; set; }
        public string Sexe { get; set; }
        public string LieuNaissance { get; set; }
        public DateTime DateNaissance { get; set; }
        public DateTime DateBapteme { get; set; }
        public string Pere { get; set; }
        public string Mere { get; set; }
        public string ProvOrigine { get; set; }
        public string TerrOrigine { get; set; }
        public string Telephone { get; set; }
        public string Pasteur { get; set; }
        public DateTime DateEnregistrement { get; set; }
        public int CountMembre()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "COUNT_MEMBRE";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["NbrMbre"] == DBNull.Value)
                        Id = 0;
                    else
                        Id = Convert.ToInt32(dr["NbrMbre"].ToString());
                }
                dr.Dispose();
            }
            return Id;

        }
        public void SaveDatas(Membre m)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd=ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_MEMBRE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, m.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@noms", 200, DbType.String, m.Noms));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@sexe", 2, DbType.String, m.Sexe));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@lieunaiss", 100, DbType.String, m.LieuNaissance));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@datenaiss", 20, DbType.Date, m.DateNaissance));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@datebapteme", 20, DbType.Date, m.DateBapteme));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pere", 200, DbType.String, m.Pere));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@mere", 200, DbType.String, m.Mere));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@provOrigine", 200, DbType.String, m.ProvOrigine));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@terrOrigine", 200, DbType.String, m.TerrOrigine));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@telephone", 20, DbType.String, m.Telephone));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pasteur", 50, DbType.String, m.Pasteur));

                cmd.ExecuteNonQuery();

                if (m.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public List<Membre> ListOfMembers()
        {
            List<Membre> lst = new List<Membre>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_ALL_MEMBRES";
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
        public List<Membre> ListOfMembersAndDepartment(string departement)
        {
            List<Membre> lst = new List<Membre>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_MEMBRE_DEPARTEMENTS";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@department", 200, DbType.String, departement));

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetMembreDepartment(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<Membre> Research(string recherche)
        {
            List<Membre> lst = new List<Membre>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Membre WHERE (Noms LIKE '%" + recherche + "%' OR Noms LIKE '%" + recherche + "' OR Noms LIKE '" + recherche + "%') ORDER By Noms";
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
        public List<Membre> ResearchMembreInDepartement(string recherche, string depart)
        {
            List<Membre> lst = new List<Membre>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Affichage_Membre_Departement WHERE Departement='"+ depart + "' AND (Noms LIKE '%" + recherche + "%' OR Noms LIKE '%" + recherche + "' OR Noms LIKE '" + recherche + "%') ORDER By Id";
                //cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetMembreDepartment(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private Membre GetMembre(IDataReader dr)
        {
            Membre m = new Membre();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.Noms = dr["Noms"].ToString();
            m.Sexe = dr["Sexe"].ToString();
            m.LieuNaissance = dr["LieuNaissance"].ToString();
            m.DateNaissance = Convert.ToDateTime(dr["DateNaissance"].ToString());
            m.DateBapteme = Convert.ToDateTime(dr["DateBapteme"].ToString());
            m.Pere = dr["NomPere"].ToString();
            m.Mere = dr["NomMere"].ToString();
            m.ProvOrigine = dr["ProvinceOrigine"].ToString();
            m.TerrOrigine = dr["TerritOrigine"].ToString();
            m.Telephone = dr["Telephone"].ToString();
            m.Pasteur = dr["Pasteur"].ToString();
            m.DateEnregistrement = Convert.ToDateTime(dr["DateEnregistrer"].ToString());

            return m;
        }
        private Membre GetMembreDepartment(IDataReader dr)
        {
            Membre m = new Membre();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.Pasteur = dr["Departement"].ToString();
            m.Noms = dr["Noms"].ToString();
            m.Sexe = dr["Sexe"].ToString();
            m.LieuNaissance = dr["LieuNaissance"].ToString();
            m.DateNaissance = Convert.ToDateTime(dr["DateNaissance"].ToString());
            m.Telephone = dr["Telephone"].ToString();
            m.DateEnregistrement = Convert.ToDateTime(dr["DateCreation"].ToString());

            return m;
        }


    }
}
