using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEPGUI.Class
{
    public class UserSession
    {
        private static UserSession inst;

        private int _id;
        private string _userName;
        private string _accessLevel;
        private string _fonction;
        private string _ability;
        private string _etat;
        private string _maison;


        public string UserName
        {
            get
            {
                return _userName;
            }

            set
            {
                _userName = value;
            }
        }
        public string Maison
        {
            get
            {
                return _maison;
            }

            set
            {
                _maison = value;
            }
        }

        public string AccessLevel
        {
            get
            {
                return _accessLevel;
            }

            set
            {
                _accessLevel = value;
            }
        }

        public string Fonction
        {
            get
            {
                return _fonction;
            }

            set
            {
                _fonction = value;
            }
        }
        public string Ability
        {
            get
            {
                return _ability;
            }

            set
            {
                _ability = value;
            }
        }
        public string Etat
        {
            get
            {
                return _etat;
            }

            set
            {
                _etat = value;
            }
        }

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

        public static UserSession GetInstance()
        {
            if (inst == null)
            {
                inst = new UserSession();
            }

            return inst;
        }
    }
}
