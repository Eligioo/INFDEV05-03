﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class DBHelper
    {
        Database<User> db;
        Database<Project> db_2;
        public DBHelper()
        {
            db = new Database<User>();
            db_2 = new Database<Project>();
        }

        public Boolean addUser(User u)
        {
            String query = "INSERT INTO employee(bsn, name, surname, headquarter_id) VALUES('" + u.Bsn + "', '" + u.Name + "', '" + u.Surname + "', '" + u.Headquarter_Id + "')";
            try { db.Insert(query); return true; }
            catch (Exception e)
            {
                return false;
                Console.WriteLine(e.Message);

            }
        }

        public Boolean editUser(User u, int bsn)
        {
            String query = "UPDATE employee SET bsn = '" + u.Bsn +"', name = '" + u.Name +"', surname = '" + u.Surname +"', headquarter_id = '" + u.Headquarter_Id + "' WHERE bsn = '" + bsn + "'";
            try { db.Update(query); return true; }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Boolean deleteUser(int bsn)
        {
            String query = "DELETE FROM employee WHERE bsn = '" + bsn + "'";
            try { db.Update(query); return true; }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<User> getAllUsers() {
            String query = "SELECT * FROM employee";
            List < User >  result = db.Select(query);
            //parse to List User
            
            return result;
        }

        public List<Project> getAllProjects()
        {
            String query = "SELECT * FROM project";
            List<Project> result = db_2.Select(query);
            //parse to List User

            return result;
        }

        public List<User> getSingleUser(int bsn)
        {
            String query = "SELECT * FROM employee WHERE bsn = '" + bsn + "'";
            List<User> result = db.Select(query);
            //parse to List User

            return result;
        }

        public List<employee_residence> getSingleUser(int bsn)
        {
            String query = "SELECT * FROM employee WHERE bsn = '" + bsn + "'";
            List<User> result = db.Select(query);
            //parse to List User

            return result;
        }
    }
}