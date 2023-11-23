using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExDB
{
    public interface IDatabase
    {
        public void Add(string data);
        public string Retrieve();
    }
}
