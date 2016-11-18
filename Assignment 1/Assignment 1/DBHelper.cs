using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class DBHelper
    {
        Database<User> user;
        Database<Project> project;
        public DBHelper()
        {
            user = new Database<User>();
            project = new Database<Project>();
        }

        public Boolean addUser(User u)
        {
            String query = "INSERT INTO employee(bsn, name, surname, headquarter_id) VALUES('" + u.Bsn + "', '" + u.Name + "', '" + u.Surname + "', '" + u.Headquarter_Id + "')";
            try { user.Insert(query); return true; }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
        }

        public Boolean editUser(User u, int bsn)
        {
            String query = "UPDATE employee SET bsn = '" + u.Bsn +"', name = '" + u.Name +"', surname = '" + u.Surname +"', headquarter_id = '" + u.Headquarter_Id + "' WHERE bsn = '" + bsn + "'";
            try { user.Update(query); return true; }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Boolean deleteUser(int bsn)
        {
            String query = "DELETE FROM employee WHERE bsn = '" + bsn + "'";
            try { user.Update(query); return true; }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<User> getAllUsers() {
            String query = "SELECT * FROM employee";
            List < User >  result = user.Select(query);
            //parse to List User
            
            return result;
        }

        public List<Project> getAllProjects()
        {
            String query = "SELECT * FROM project";
            List<Project> result = project.Select(query);
            //parse to List User

            return result;
        }

        public List<User> getSingleUser(int bsn)
        {
            String query = "SELECT * FROM employee WHERE bsn = '" + bsn + "'";
            List<User> result = user.Select(query);
            //parse to List User

            return result;
        }

        public List<Project> getSingleProject(int projectId)
        {
            String query = "SELECT * FROM project WHERE id = '" + projectId + "'";
            List<Project> result = project.Select(query);

            return result;

        }

        public Boolean addProject(Project p)
        {
            String query = "INSERT INTO project(name, buget, allocated_hours, headquarters_id) VALUES('"+ p.Name +"', '"+ p.Buget +"', '"+ p.Allocated_hours +"', '"+ p.Headquarters_Id +"')";
            try { project.Insert(query); return true; }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
        }

        public Boolean editProject(Project p, int projectId)
        {
            //update hq id not implemented yet
            String query = "UPDATE project SET name = '"+ p.Name +"', buget = '"+ p.Buget +"', allocated_hours = '"+ p.Allocated_hours +"' WHERE id = '" + projectId+"'";
            try { project.Insert(query); return true; }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
        }

        public Boolean deleteProject(int projectId)
        {
            String query = "DELETE FROM project WHERE id = '"+ projectId +"'";
            try { project.Delete(query); return true; }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
