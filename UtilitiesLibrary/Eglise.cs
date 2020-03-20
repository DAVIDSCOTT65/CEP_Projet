using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLibrary
{
    public class Eglise
    {
        int _id;
        string _nom;
        string _communaute;
        string _acronyme;
        string _adresse;
        string _telephone1;
        string _telephone2;
        string _mail;
        Image _logo;
        string _siteweb;
        

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
         public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }
        public string Communaute
        {
            get
            {
                return _communaute;
            }

            set
            {
                _communaute = value;
            }
        }
        public string Acronyme
        {
            get
            {
                return _acronyme;
            }

            set
            {
                _acronyme = value;
            }
        }
        public string Adresse
        {
            get
            {
                return _adresse;
            }

            set
            {
                _adresse = value;
            }
        }
        public string Telephone1
        {
            get
            {
                return _telephone1;
            }

            set
            {
                _telephone1 = value;
            }
        }
        public string Telephone2
        {
            get
            {
                return _telephone2;
            }

            set
            {
                _telephone2 = value;
            }
        }
        public string Mail
        {
            get
            {
                return _mail;
            }

            set
            {
                _mail = value;
            }
        }
        public Image Logo
        {
            get
            {
                return _logo;
            }

            set
            {
                _logo = value;
            }
        }
        public string Siteweb
        {
            get
            {
                return _siteweb;
            }

            set
            {
                _siteweb = value;
            }
        }
        private byte[] converttoByteImage(Image img)
        {
            MemoryStream ms = new MemoryStream();
            Bitmap bmpImage = new Bitmap(img);
            byte[] bytImage;
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            bytImage = ms.ToArray();
            ms.Close();
            return bytImage;
        }
        public void Enregistrer(Eglise tonti)
        {

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT_EGLISE";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@id", 4, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@nom", 100, DbType.String, Nom.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@comm", 100, DbType.String, Communaute.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@acro", 20, DbType.String, Acronyme.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@adresse", 100, DbType.String, Adresse.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@telephone", 20, DbType.String, Telephone1.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@telephone2", 20, DbType.String, Telephone2.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@mail", 100, DbType.String, Mail.Trim()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@logo", int.MaxValue, DbType.Binary, converttoByteImage(Logo)));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@siteweb", 100, DbType.String, Siteweb.Trim()));

                cmd.ExecuteNonQuery();


            }

        }
        public List<Eglise> Details()
        {
            List<Eglise> lst = new List<Eglise>();
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT_EGLISE";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetDatas(dr));
                }
                dr.Dispose();
                dr.Close();
            }
            return lst;
        }
        private Eglise GetDatas(IDataReader dr)
        {
            Eglise tont = new Eglise();

            tont.Id = Convert.ToInt32(dr["Id"].ToString());
            tont.Nom = dr["Nom"].ToString();
            tont.Communaute = dr["Communaute"].ToString();
            tont.Acronyme = dr["Accronyme"].ToString();
            tont.Adresse = dr["Adresse"].ToString();
            tont.Telephone1 = dr["Telephone2"].ToString();
            tont.Telephone2 = dr["Telephone3"].ToString();
            tont.Mail = dr["Mail"].ToString();
            tont.Siteweb = dr["Siteweb"].ToString();

            return tont;

        }
    }
}
