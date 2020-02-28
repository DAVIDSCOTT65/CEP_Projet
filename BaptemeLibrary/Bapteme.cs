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
    public class Bapteme
    {
        public int Id { get; set; }
        public string Lieu { get; set; }
        public DateTime DateCelebration { get; set; }
        public string Pasteur { get; set; }
        public DateTime DateCreation { get; set; }
        public void SaveDatas(Bapteme d)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_BAPTEME";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, d.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@lieu", 100, DbType.String, d.Lieu));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@date", 20, DbType.Date, d.DateCelebration));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@pasteur", 100, DbType.String, d.Pasteur));

                cmd.ExecuteNonQuery();

                if (d.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }
}
