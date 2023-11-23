using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExDB.ConcreteClases
{
    //esta en lugar de imlpementar, se le inyecta por dependencia la bd
    public class SAPDB 
    {
        private readonly IDatabase _database;
        public SAPDB(IDatabase database)
        {
            _database = database;
        }
        public void SaveData(string data)
        {
            _database.Add(data);
            Console.WriteLine($"Insertando en SAP: {data}");
        }

        public void LoadData()
        {
            string data = _database.Retrieve();
            Console.WriteLine($"Data loaded in the new system {data}");
        }
    }
}
