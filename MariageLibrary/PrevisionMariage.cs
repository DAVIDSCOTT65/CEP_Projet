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
    public class PrevisionMariage
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public int RefMariage { get; set; }
        public int RefConjoint { get; set; }
        public int RefConjointe { get; set; }
        public int RefParrainage { get; set; }
        public DateTime DateCreation { get; set; }

        public string Conjoint { get; set; }
        public string Conjointe { get; set; }
        public string Parrain { get; set;}
        public string Marraine { get; set; }
        public DateTime DateCelebration { get; set; }
        public string Pasteur { get; set; }

        public void SaveDatas(PrevisionMariage d)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_MARIAGE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, d.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refmariage", 5, DbType.Int32, d.RefMariage));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refconjoint", 5, DbType.Int32, d.RefConjoint));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refconjointe", 5, DbType.Int32, d.RefConjointe));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refparrainage", 5, DbType.Int32, d.RefParrainage));

                cmd.ExecuteNonQuery();

                if (d.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public List<PrevisionMariage> ListOfPrevisions()
        {
            List<PrevisionMariage> lst = new List<PrevisionMariage>();

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
        public List<PrevisionMariage> Research(string recherche)
        {
            List<PrevisionMariage> lst = new List<PrevisionMariage>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM PrevisionMariage WHERE (Conjoint LIKE '%" + recherche + "%' OR Conjoint LIKE '%" + recherche + "' OR Conjoint LIKE '" + recherche + "%') ORDER By Id DESC";
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
        private PrevisionMariage GetPrevision(IDataReader dr)
        {
            PrevisionMariage m = new PrevisionMariage();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.Conjoint = dr["Conjoint"].ToString();
            m.Conjointe = dr["Conjointe"].ToString();
            m.Parrain = dr["Parrain"].ToString();
            m.Marraine = dr["Marraine"].ToString();
            m.DateCelebration = Convert.ToDateTime(dr["DateCelebration"].ToString());
            m.Pasteur = dr["Pasteur"].ToString();


            return m;
        }
    }
}
