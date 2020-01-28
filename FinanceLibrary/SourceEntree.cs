using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceLibrary
{
    public class SourceEntree
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public string Designation { get; set; }
        public DateTime DateCreation { get; set; }
        public void SaveDatas(SourceEntree a)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_SOURCE_ENTREE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, a.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@designation", 100, DbType.String, a.Designation));

                cmd.ExecuteNonQuery();

                if (a.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public List<SourceEntree> ListOfSources()
        {
            List<SourceEntree> lst = new List<SourceEntree>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetSource(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<SourceEntree> Research(string recherche)
        {
            List<SourceEntree> lst = new List<SourceEntree>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM SourceEntree WHERE (Designation LIKE '%" + recherche + "%' OR Designation LIKE '%" + recherche + "' OR Designation LIKE '" + recherche + "%') ORDER By Id DESC";
                //cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetSource(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private SourceEntree GetSource(IDataReader dr)
        {
            SourceEntree m = new SourceEntree();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.Designation = dr["Designation"].ToString();
            m.DateCreation = Convert.ToDateTime(dr["DateCreation"].ToString());


            return m;
        }
    }
}
