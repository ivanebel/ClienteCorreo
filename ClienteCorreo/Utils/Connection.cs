using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClienteCorreo.Utils
{
 
    public class Connection
    {
        private String url = "localhost";
        private String db = "clientecorreos";
        private String user = "root";
        private String pwd = "";
        private String driver = "";
        private String connString = "";

        private static Connection instance = null;

        public String Url
        {
            get { return url; }
            set { url = value; }
        }

        public String Db
        {
            get { return db; }
            set { db = value; }
        }

        public String User
        {
            get { return user; }
            set { user = value; }
        }

        public String Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }

        public String Driver
        {
            get { return driver; }
            set { driver = value; }
        }

        public String ConnString {
            get {
                //"Server=" & coll_dbconfig(1) & "; Database=" & coll_dbconfig(2) & "; Uid=" & coll_dbconfig(3) & "; Pwd=" & coll_dbconfig(4) & ";"
                String str = "Server=" + url + "; Database=" + db + "; Uid=" + user + "; Pwd=" + pwd + ";";
                return str; }
            set {
                connString = driver + ":" + url + ";" + db + ";" + user + ";" + pwd + ";";
            }
        }

        public String GetConnectionString() { 
            String str = "Server=" + url + "; Database=" + db + "; Uid=" + user + "; Pwd=" + pwd + ";";
            return str; 
        }

        private Connection() { }

        public static Connection getInstance() {
            if (instance == null) instance = new Connection();
            return instance;
        }
        
    }
}
