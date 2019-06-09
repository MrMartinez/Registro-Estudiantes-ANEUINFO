using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Helpers
{
    public class SingletonConnection
    {
        private static SingletonConnection instance = null;
        public string  _connection = "Data Source=.;Initial Catalog=dbRegistro;Integrated Security=True;";

        public SingletonConnection()
        {

        }

        public static SingletonConnection Instance
        {
            get
            {
                if (instance == null)
             
                    instance = new SingletonConnection();
                    return instance;
               
            }
        }
    }
}
