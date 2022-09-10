using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    public class ConnectionDetails
    {
        private string server = "gotogre.cdkgb6huayqe.ap-south-1.rds.amazonaws.com";
        private string db = "IntegraDev";
        private string username = "admin";
        private string pw = "admin1234";
        private string constring;

        private MySqlConnection conn;

        public ConnectionDetails()
        {
            constring = $"SERVER={server};DATABASE={db};UID={username};PASSWORD={pw};Convert Zero Datetime=True;";
            conn = new MySqlConnection(constring);
        }

        public MySqlConnection Conn
        {
            get { return conn; }
        }
    }
}
