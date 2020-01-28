using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreLibrary
{
    public class Parametre
    {
        public static Parametre _instance;

        public static Parametre Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Parametre();
                return _instance;
            }
        }
        public IDbDataParameter AddParametres(IDbCommand cmd, string parameterName, int size, DbType type, object value)
        {
            IDbDataParameter param = cmd.CreateParameter();

            param.ParameterName = parameterName;
            param.DbType = type;
            param.Size = size;
            param.Value = value;

            return param;
        }
    }
}
