using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsAndLines
{
    class user
    {
        private string username;
        private int password;

        public int MyProperty1 
        { 
            
            get
            { 
                return password;
            } 
            set
            { 
                password = value;
            } 
        }

        public string MyProperty2 
        { 
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
                
          }


        public user(string username, int password) 
        {
            this.username = username;
            this.password = password;
            
        }

    }
}

