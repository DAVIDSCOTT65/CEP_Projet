using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariageLibrary
{
    public class FaireMariage
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public int RefPrev { get; set; }
        public DateTime DateMariage { get; set; }
         public string Pasteur { get; set; }

        public string Conjoint { get; set; }
        public string Conjointe { get; set; }
        public string Parrain { get; set; }
        public string Marraine { get; set; }
        public void SaveDatas(FaireMariage d)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_FAIRE_MARIAGE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, d.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refprevision", 5, DbType.Int32, d.RefPrev));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@date", 20, DbType.Date, d.DateMariage));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pasteur", 50, DbType.String, d.Pasteur));


                cmd.ExecuteNonQuery();

                if (d.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public List<FaireMariage> ListOfMariageCelebrer()
        {
            List<FaireMariage> lst = new List<FaireMariage>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetPrevision(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<FaireMariage> Research(string recherche)
        {
            List<FaireMariage> lst = new List<FaireMariage>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM FaireMariage WHERE (Conjoint LIKE '%" + recherche + "%' OR Conjoint LIKE '%" + recherche + "' OR Conjoint LIKE '" + recherche + "%') ORDER By Id DESC";
                //cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetPrevision(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private FaireMariage GetPrevision(IDataReader dr)
        {
            FaireMariage m = new FaireMariage();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.Conjoint = dr["Conjoint"].ToString();
            m.Conjointe = dr["Conjointe"].ToString();
            m.Parrain = dr["Parrain"].ToString();
            m.Marraine = dr["Marraine"].ToString();
            m.DateMariage = Convert.ToDateTime(dr["DateCelebration"].ToString());
            m.Pasteur = dr["Pasteur"].ToString();


            return m;
        }
    }
}
