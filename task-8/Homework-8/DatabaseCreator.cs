using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    static class DatabaseCreator
    {
        public static IDatabase CreateDatabase()
        {
            IDatabase dataBase = new InMemoryDatabase();
            return dataBase;
        }
    }
}
