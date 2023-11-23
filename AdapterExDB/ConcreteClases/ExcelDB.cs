using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExDB.ConcreteClases
{
    public class ExcelDB
    {
        public void InsertData(string data)
        {
            Console.WriteLine( $"Agregando dato a Excel: {data}");

        }

        public string GetData() 
        {
            return "Obteniendo todos los datos de Excel"; 
        }
    }
}
