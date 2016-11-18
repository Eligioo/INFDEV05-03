using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class DBHelper
    {
        Database<User> db;
        public DBHelper()
        {
            db = new Database<User>();
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

        public List<User> getAllUsers() {
            String query = "SELECT * FROM employee";
            List < User >  result = db.Select(query);
            //parse to List User
            
            return result;
        }

    }
}
