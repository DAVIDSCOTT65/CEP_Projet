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
    public class Entree
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public int RefDepart { get; set; }
        public int RefSource { get; set; }
        public double Montant { get; set; }
        public DateTime DateEntree { get; set; }
        public string Source { get; set; }
        public string Departement { get; set; }
        public void SaveDatas(Entree d)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_ENTREE";
                cmd.CommandType = CommandType.StoredProcedure;
                
                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, d.Id));
                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refdepart", 5, DbType.Int32, d.RefDepart));
                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refsource", 5, DbType.Int32, d.RefSource));
                    cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@montant", 10, DbType.Double, d.Montant));
                
                 cmd.ExecuteNonQuery();

                if (d.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public List<Entree> ListOfEntree()
        {
            List<Entree> lst = new List<Entree>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_ENTREE_FINANCE";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetEntree(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<Entree> Research(string recherche)
        {
            List<Entree> lst = new List<Entree>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Affichage_Finance_Entree WHERE (Designation LIKE '%" + recherche + "%' OR Designation LIKE '%" + recherche + "' OR Designation LIKE '" + recherche + "%') ORDER By Id DESC";
                //cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetEntree(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private Entree GetEntree(IDataReader dr)
        {
            Entree m = new Entree();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.Source = dr["Designation"].ToString();
            m.Departement = dr["Departement"].ToString();
            m.Montant = Convert.ToDouble(dr["Montant"].ToString());
            m.DateEntree = Convert.ToDateTime(dr["DateEntree"].ToString());


            return m;
        }
    }
}
