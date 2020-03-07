﻿using ManageSingleConnexion;
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
    public class Baptiser
    {
        int i = 0;
        string procedure = "";
        public int Num { get; set; }
        public int Id { get; set; }
        public DateTime DateBapteme { get; set; }
        public string LieuBapteme { get; set; }
        public int RefPrevision { get; set; }
        public string Noms { get; set; }
        public string Sexe { get; set; }
        public string Pasteur { get; set; }
        public void SaveDatas(Baptiser d)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_BAPTISER";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@idModif", 5, DbType.Int32, d.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@datebapteme", 5, DbType.Date, d.DateBapteme));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@refprevision", 5, DbType.Int32, d.RefPrevision));

                cmd.ExecuteNonQuery();

                if (d.Id > 0)
                    MessageBox.Show("Modification effectuer avec succès", "Mofification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        public List<Baptiser> ListOfBaptiser(string proc)
        {
            procedure = proc;
            List<Baptiser> lst = new List<Baptiser>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetBaptiser(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<Baptiser> Research(string recherche)
        {
            List<Baptiser> lst = new List<Baptiser>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Membre WHERE (Noms LIKE '%" + recherche + "%' OR Noms LIKE '%" + recherche + "' OR Noms LIKE '" + recherche + "%') AND DateBapteme<>'' ORDER By Noms";
                //cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lst.Add(GetBaptiser(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private Baptiser GetBaptiser(IDataReader dr)
        {
            Baptiser m = new Baptiser();

            i = i + 1;

            m.Num = i;
            m.Id = Convert.ToInt32(dr["Id"].ToString());
            m.Noms = dr["Noms"].ToString();
            m.Sexe = dr["Sexe"].ToString();
            m.DateBapteme = Convert.ToDateTime(dr["DateBapteme"].ToString());
            if(procedure != "SELECT_ALL_MEMBRE_BAPTISER")
            {
                m.LieuBapteme = dr["Lieu"].ToString();
                m.Pasteur = dr["Pasteur"].ToString();
            }
                


            return m;
        }
        public int CountBapteme()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "COUNT_BAPTISER";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["NbrBapt"] == DBNull.Value)
                        Id = 0;
                    else
                        Id = Convert.ToInt32(dr["NbrBapt"].ToString());
                }
                dr.Dispose();
            }
            return Id;

        }
    }
}
