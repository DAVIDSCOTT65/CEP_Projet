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
    public class Communiquer
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public string DetailsComm { get; set; }
        public DateTime DatePublication { get; set; }
        public DateTime DateCreation { get; set; }
        public string Activite { get; set; }
        public void SaveDatas(Communiquer d)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_COMMUNIQUE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, d.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@detailscom", 255, DbType.String, d.DetailsComm));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@datepublication", 20, DbType.Date, d.DatePublication));

                cmd.ExecuteNonQuery();

                //if (d.Id > 0)
                //    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public List<Communiquer> ListOfAnnonces(string depart)
        {
            List<Communiquer> lst = new List<Communiquer>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "ANNONCE_SMS";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@departement", 100, DbType.String, depart));

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetActivite(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        private Communiquer GetActivite(IDataReader dr)
        {
            Communiquer m = new Communiquer();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.Activite = dr["DetailsCommunique"].ToString();
            m.DateCreation = Convert.ToDateTime(dr["DatePublication"].ToString());


            return m;
        }
        public string GetAnnonceSms(string depart)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "ANNONCE_SMS";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@departement", 100, DbType.String, depart));

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["DetailsCommunique"] == DBNull.Value)
                        DetailsComm = "Rien à affiché";
                    else
                        DetailsComm = dr["DetailsCommunique"].ToString();
                }
                else
                {
                    DetailsComm = "Rien à affiché";
                }
                dr.Dispose();
            }
            return DetailsComm;

        }
    }
}
