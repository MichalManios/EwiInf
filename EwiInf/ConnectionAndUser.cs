using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EwiInf
{
    [Serializable()]
    class ConnectionAndUser
    {
        private string user = "Admin";
        private string password = "Haslo123";
        private string serverName = "";
        private string serverSQLinstance = "";
        private string databaseName = "";
        private string connectionString = "";
        public string ConnectionString { get { return connectionString; } }
        public string User { get { return user; } }
        public string Password { get { return password; } set { password = value; } }
        public string ServerName { get { return serverName; } }
        public string ServerSQLinstance { get { return serverSQLinstance; } }
        public string DatabaseName { get { return databaseName; } }

        public bool NotEmpty()
        {
            if (user != "" && password != "" && serverName != "" && serverSQLinstance != "" && databaseName != "") return true;
            else return false;
        }

        public void SetFields(string User, string Password, string ServerName, string ServerSQLinstance, string DatabaseName)
        {
            this.user = User;
            this.password = Password;
            this.serverName = ServerName;
            this.serverSQLinstance = ServerSQLinstance;
            this.databaseName = DatabaseName;
            connectionString = "Data Source=" + serverName + "\\" + serverSQLinstance + ";Initial Catalog=" + databaseName + ";User ID=" + User + ";Password=" + password + ";";
        }

        public bool CheckUserAndPassword(string User, string Password)
        {
            if (user != User || password != Password) return false;
            else return true;
        }
    }
}
