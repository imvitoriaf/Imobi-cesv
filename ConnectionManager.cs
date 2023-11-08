using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace ImobCESV
{
    public class ConnectionManager
    {
        private static string stringConexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\\Users\\Vitoria\\Documents\\bancoimobicesv.mdb"; 

        public  static string getConexao() {
            return stringConexao;
        }
    }
}