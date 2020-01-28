using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaptemeLibrary
{
    public class PrevisionBapteme
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public int RefMembre { get; set; }
        public int RefBapteme { get; set; }
        public string Noms { get; set; }
        public string Sexe { get; set; }
        public string Lieu { get; set; }
        public DateTime DateCelebration { get; set; }
        public string Pasteur { get; set; }
        public void SaveDatas(PrevisionBapteme d)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_PREVISION_BAPTEME";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, d.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refmembre", 5, DbType.Int32, d.RefMembre));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refbapteme", 5, DbType.Int32, d.RefBapteme));

                cmd.ExecuteNonQuery();

                if (d.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public List<PrevisionBapteme> ListOfPrevisions()
        {
            List<PrevisionBapteme> lst = new List<PrevisionBapteme>();

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
        public List<PrevisionBapteme> Research(string recherche)
        {
            List<PrevisionBapteme> lst = new List<PrevisionBapteme>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM PrevisionBapteme WHERE (Noms LIKE '%" + recherche + "%' OR Noms LIKE '%" + recherche + "' OR Noms LIKE '" + recherche + "%') ORDER By Id DESC";
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
        private PrevisionBapteme GetPrevision(IDataReader dr)
        {
            PrevisionBapteme m = new PrevisionBapteme();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.Noms = dr["Noms"].ToString();
            m.Sexe = dr["Sexe"].ToString();
            m.Lieu = dr["Lieu"].ToString();
            m.DateCelebration = Convert.ToDateTime(dr["DateCelebration"].ToString());
            m.Pasteur = dr["Pasteur"].ToString();


            return m;
        }
    }
}
