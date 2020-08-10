using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SqliteDataAccess : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);
            output += " (from SQLite)";
            return output;
        }

        // Needs to override DataAccess.LoadData
        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading SQLite Data");
        }

        // Needs to override DataAccess.SaveData
        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }
    }
}
