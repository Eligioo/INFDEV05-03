using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class DBHelper
    {
        Database db;
        public DBHelper()
        {
            db = new Database();
        }

        public Boolean addUser(User u)
        {
            String query = "INSERT INTO `employee`(`bsn`, `name`, `surname`) VALUES(`" + u.Bsn + "`, `" + u.Name + "`, `" + u.Surname + "`)";
            try { db.Insert(query); return true; }
            catch (Exception e)
            {
                return false;
                Console.WriteLine(e.Message);

            }
        }

        public List<object> getAllUsers() {
            String query = "SELECT * FROM employee";
            List < Object >  result = db.Select(query);
            //parse to List User
            
            return result;
        }

    }
}
