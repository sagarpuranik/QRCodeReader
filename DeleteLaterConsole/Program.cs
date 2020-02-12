using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeleteLaterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source:(local)", "SQL","Microsoft");
            Console.Read();
        }        

    }

    public abstract class connections
    {
        private string _connection;
        private string _type;
        public connections(string con,string type)
        {
            _connection = con;
            _type = type;

            Console.WriteLine(_connection + " => " + _type);
        }
    }

    public class SqlConnection : connections
    {
        
        public SqlConnection(string con, string type, string name) : base(con, type)
        {
            Console.WriteLine(" Sql Connection class");
        }        
    }
}
