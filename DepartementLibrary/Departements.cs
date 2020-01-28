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
    public class Departements
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public string Departement { get; set; }
        public DateTime DateCreation { get; set; }
        public int NbrFideles { get; set; }
        public void SaveDatas(Departements d)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_DEPARTEMENT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, d.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@departement", 100, DbType.String, d.Departement));

                cmd.ExecuteNonQuery();

                if (d.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public List<Departements> ListOfDepartements()
        {
            List<Departements> lst = new List<Departements>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetDepartement(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<Departements> Research(string recherche)
        {
            List<Departements> lst = new List<Departements>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Departement WHERE (Departement LIKE '%" + recherche + "%' OR Departement LIKE '%" + recherche + "' OR Departement LIKE '" + recherche + "%') ORDER By Id DESC";
                //cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetDepartement(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private Departements GetDepartement(IDataReader dr)
        {
            Departements m = new Departements();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.Departement = dr["Departement"].ToString();
            m.NbrFideles = Convert.ToInt32(dr["NbrFidele"].ToString());
            m.DateCreation = Convert.ToDateTime(dr["DateCreation"].ToString());
           

            return m;
        }

    }
}
