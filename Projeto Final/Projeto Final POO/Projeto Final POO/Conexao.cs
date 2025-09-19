using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_POO
{
        internal class ConexaoString
        {
            string serverName = "200.131.206.7";
            string port = "5433";
            string userName = "anacastelhone";
            string password = "senha";
            string dataBaseName = "anacastelhone";

            public string ConnString()
            {
             var connString = "server=" + serverName + ";port = " + port + ";username = " + userName + ";password = " + password + ";Database = " + dataBaseName + ";";

            return connString;
            }
        }
    
}
