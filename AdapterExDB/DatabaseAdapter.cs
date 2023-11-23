using AdapterExDB.ConcreteClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExDB
{
    public class DatabaseAdapter : IDatabase
    {
        private readonly ExcelDB _excel;
        public DatabaseAdapter(ExcelDB excel)
        {
            _excel = excel;
        }

        public void Add(string data)
        {
            _excel.InsertData(data);
        }

        public string Retrieve()
        {
            return _excel.GetData();
        }
    }
}
