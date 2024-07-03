using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IDataBaseFactory
    {
        string DatabaseType();
    }
    public class Oracle : IDataBaseFactory
    {
        public string DatabaseType()
        {
            return " Oracle DataBase Connection";
        }
    }
    public class SQL : IDataBaseFactory
    {
        public string DatabaseType()
        {
            return " SQL DataBase Connection";
        }
    }
    public class PostGress : IDataBaseFactory
    {
        public string DatabaseType()
        {
            return " PostGress DataBase Connection";
        }
    }
    public class NoSqlDatabase : IDataBaseFactory
    {
        public string DatabaseType()
        {
            return " NoSqlDatabase DataBase Connection";
        }
    }

    public class DataBaseFactory
    {
        public static IDataBaseFactory GetBaseFactory(string type)
        {
            IDataBaseFactory dataBaseFactory = null;
            if (type.ToLower().Equals("oracle"))
            {
                dataBaseFactory = new Oracle();
            }
            else if(type.ToLower().Equals("sql"))
            {
                dataBaseFactory = new SQL();
            }
            else if (type.ToLower().Equals("noSqldatabase"))
            {
                dataBaseFactory = new NoSqlDatabase();
            }
            else if(type.ToLower().Equals("postgress"))
            {
                dataBaseFactory= new PostGress();
            }
            else
            {
                Console.WriteLine("Invalid Database Factory " + type);
            }
            return dataBaseFactory;
        }
    }
}
