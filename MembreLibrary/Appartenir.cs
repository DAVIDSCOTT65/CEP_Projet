using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MembreLibrary
{
    public class Appartenir
    {
        public int Id { get; set; }
        public int RefMembre { get; set; }
        public int RefDepartement { get; set; }
        public void SaveDatas(Appartenir A)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_APPARTENANCE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, A.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refmembre", 5, DbType.Int32, A.RefMembre));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refdepart", 5, DbType.Int32, A.RefDepartement));

                cmd.ExecuteNonQuery();

                if (A.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        
    }
}
