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
    public class Depenses
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public int RefDepart { get; set; }
        public int RefType { get; set; }
        public double Montant { get; set; }
        public DateTime DateDepense { get; set; }
        public string Departement { get; set; }
        public string TypeDepense { get; set; }
        public void SaveDatas(Depenses d)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_ENTREE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, d.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refdepart", 5, DbType.Int32, d.RefDepart));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@@reftype", 5, DbType.Int32, d.RefType));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@montant", 10, DbType.Double, d.Montant));


                cmd.ExecuteNonQuery();

                if (d.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public List<Depenses> ListOfDepenses()
        {
            List<Depenses> lst = new List<Depenses>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetDepense(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<Depenses> Research(string recherche)
        {
            List<Depenses> lst = new List<Depenses>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Depenses WHERE (Designation LIKE '%" + recherche + "%' OR Designation LIKE '%" + recherche + "' OR Designation LIKE '" + recherche + "%') ORDER By Id DESC";
                //cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetDepense(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private Depenses GetDepense(IDataReader dr)
        {
            Depenses m = new Depenses();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.TypeDepense = dr["Designation"].ToString();
            m.Departement = dr["Departement"].ToString();
            m.Montant = Convert.ToDouble(dr["Montant"].ToString());
            m.DateDepense = Convert.ToDateTime(dr["DateDepense"].ToString());


            return m;
        }
    }
}
