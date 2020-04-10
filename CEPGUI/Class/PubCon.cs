using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLibrary;

namespace CEPGUI
{
    class PubCon
    {
        public static String connec;
        public static String dataS;
        public static String initcat;
        public static String id;
        public static String pass;
        public static String niveau;

        public static int testlog;
        public static String codfact;
        public static string codrec;


        public static void testFile()
        {
            if (Directory.Exists(ClsConstantes.Table.InitialDirectory) == true) { }

            else
            {
                Directory.CreateDirectory(ClsConstantes.Table.PrincipalDirectory);
                Directory.CreateDirectory(ClsConstantes.Table.InitialDirectory);
            }

            if (File.Exists(ClsConstantes.Table.serveur) == true && File.Exists(ClsConstantes.Table.database) == true && File.Exists(ClsConstantes.Table.user) == true && File.Exists(ClsConstantes.Table.password) == true)
            {
                ClsConnection.GetInstance().connecter();
            }
            else
            {

                Form1 frm = new Form1();
                frm.ShowDialog();
                ClsConnection.GetInstance().connecter();
            }
        }
    }
}
