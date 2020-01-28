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
    public class Activites
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public string Activite { get; set; }
        public DateTime DateCreation { get; set; }
        public void SaveDatas(Activites a)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_ACTIVITE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, a.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@activite", 100, DbType.String, a.Activite));

                cmd.ExecuteNonQuery();

                if (a.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public List<Activites> ListOfActivites()
        {
            List<Activites> lst = new List<Activites>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetActivite(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<Activites> Research(string recherche)
        {
            List<Activites> lst = new List<Activites>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Actitive WHERE (Activite LIKE '%" + recherche + "%' OR Activite LIKE '%" + recherche + "' OR Activite LIKE '" + recherche + "%') ORDER By Id DESC";
                //cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetActivite(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private Activites GetActivite(IDataReader dr)
        {
            Activites m = new Activites();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.Activite = dr["Activite"].ToString();
            m.DateCreation = Convert.ToDateTime(dr["DateCreation"].ToString());


            return m;
        }
    }
}
