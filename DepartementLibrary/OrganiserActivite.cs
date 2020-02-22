using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartementLibrary
{
    public class OrganiserActivite
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public DateTime DateActivite { get; set; }
        public string Heure { get; set; }
        public int RefDepart { get; set; }
        public int RefActivite { get; set; }
        public string Description { get; set; }
        public DateTime DateCreation { get; set; }
        public string Departement { get; set; }
        public string Activite { get; set; }
        public void SaveDatas(OrganiserActivite o)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_ORGANISER_ACTIVITE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, o.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@date", 100, DbType.Date, o.DateActivite));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@heure", 100, DbType.String, o.Heure));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refdepart", 5, DbType.Int32, o.RefDepart));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refactivite", 5, DbType.Int32, o.RefActivite));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@description", 100, DbType.String, o.Description));


                cmd.ExecuteNonQuery();

                if (o.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public List<OrganiserActivite> ListOfActivites()
        {
            List<OrganiserActivite> lst = new List<OrganiserActivite>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_ACTIVITES";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetOrganiser(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<OrganiserActivite> Research(string recherche)
        {
            List<OrganiserActivite> lst = new List<OrganiserActivite>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM OrganiserActivite WHERE (DateActivite LIKE '%" + recherche + "%' OR DateActivite LIKE '%" + recherche + "' OR DateActivite LIKE '" + recherche + "%') ORDER By Id DESC";
                //cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetOrganiser(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        public int CountActivite()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "COUNT_ACTIVITE";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["NbrActiv"] == DBNull.Value)
                        Id = 0;
                    else
                        Id = Convert.ToInt32(dr["NbrActiv"].ToString());
                }
                dr.Dispose();
            }
            return Id;

        }
        private OrganiserActivite GetOrganiser(IDataReader dr)
        {
            OrganiserActivite m = new OrganiserActivite();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.DateActivite = Convert.ToDateTime(dr["DateHeure"].ToString());
            m.Departement = dr["Departement"].ToString();
            m.Activite = dr["Activite"].ToString();
            m.Description = dr["Description"].ToString();

            return m;
        }
    }
}
