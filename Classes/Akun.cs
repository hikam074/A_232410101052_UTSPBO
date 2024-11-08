using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_UTS.Classes
{
    internal class Akun
    {
        public string username;
        protected string password;

        public string getPassword()
        {
            return password;
        }
        public void setPassword(string input)
        {
            this.password = input;
        }
    }
}
