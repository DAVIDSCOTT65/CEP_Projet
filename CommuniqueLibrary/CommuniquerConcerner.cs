using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommuniqueLibrary
{
    public class CommuniquerConcerner
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public int RefDepart { get; set; }
        public int RefComm { get; set; }
        public string Depart { get; set; }
        public string DetailsComm { get; set; }
        public DateTime DatePublication { get; set; }
        public DateTime DateCreation { get; set; }
        public void SaveDatas(CommuniquerConcerner d)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_COMMUNIQUE_CONCERNER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, d.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refdepart", 5, DbType.Int32, d.RefDepart));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refcom", 5, DbType.Int32, d.RefComm));

                cmd.ExecuteNonQuery();

                if (d.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public List<CommuniquerConcerner> ListOfCommuniquer()
        {
            List<CommuniquerConcerner> lst = new List<CommuniquerConcerner>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetCommuniquer(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<CommuniquerConcerner> Research(string recherche)
        {
            List<CommuniquerConcerner> lst = new List<CommuniquerConcerner>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM CommuniquerConcerner WHERE (DatePublication LIKE '%" + recherche + "%' OR DatePublication LIKE '%" + recherche + "' OR DatePublication LIKE '" + recherche + "%') ORDER By Id DESC";
                //cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetCommuniquer(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private CommuniquerConcerner GetCommuniquer(IDataReader dr)
        {
            CommuniquerConcerner m = new CommuniquerConcerner();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.Depart = dr["Departement"].ToString();
            m.DetailsComm = dr["DetailsComm"].ToString();
            m.DatePublication = Convert.ToDateTime(dr["DatePublication"].ToString());


            return m;
        }
    }
}
