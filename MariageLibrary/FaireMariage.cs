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

        public string CoupleM { get; set; }
        public string CoupleP { get; set; }
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
                cmd.CommandText = "SELECT_MARIAGES_CELEBRES";
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
                cmd.CommandText = "SELECT * FROM Affichage_Mariages_Celebrer WHERE (Couples LIKE '%" + recherche + "%' OR Couples LIKE '%" + recherche + "' OR Couples LIKE '" + recherche + "%') ORDER By Id DESC";
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
            m.CoupleM = dr["Couples"].ToString();
            m.CoupleP = dr["Couple_Parrainage"].ToString();
            m.DateMariage = Convert.ToDateTime(dr["DateMariage"].ToString());
            m.Pasteur = dr["Pasteur"].ToString();
            m.RefPrev = Convert.ToInt32(dr["Id"].ToString());

            m.Conjoint = dr["RefPrevision"].ToString();
            m.Conjointe = dr["Conjointe"].ToString();
            m.Parrain = dr["NomsParrain"].ToString();
            m.Marraine = dr["NomsMarraine"].ToString();


            return m;
        }
        public int CountMariage()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "COUNT_MARIAGE";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["NbrMar"] == DBNull.Value)
                        Id = 0;
                    else
                        Id = Convert.ToInt32(dr["NbrMar"].ToString());
                }
                dr.Dispose();
            }
            return Id;

        }
    }
}
