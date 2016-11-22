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
        Database<Headquarter> headquarter;
        Database<Residence> residence;
        Database<Degree> degree;
        Database<Degree_employee> degree_employee;
        public DBHelper()
        {
            user = new Database<User>();
            project = new Database<Project>();
            headquarter = new Database<Headquarter>();
            residence = new Database<Residence>();
            degree = new Database<Degree>();
            degree_employee = new Database<Degree_employee>();
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
            String query = "UPDATE project SET name = '"+ p.Name +"', buget = '"+ p.Buget +"', allocated_hours = '"+ p.Allocated_hours + "', headquarters_id = '"+p.Headquarters_Id+"' WHERE id = '" + projectId+"'";
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

        public List<Headquarter> getHeadquarterList()
        {
            String query = "SELECT * FROM headquarter";
            List<Headquarter> result = headquarter.Select(query);
            return result;
        }

        public Boolean addHeadquarter(Headquarter h)
        {
            String query = "INSERT INTO headquarter(building_name, rooms, rent, country, city, street, number, postal_code) VALUES('"+ h.Building_name +"', '"+ h.Rooms +"', '"+ h.Rent +"', '"+ h.Country +"', '"+ h.City +"', '"+ h.Street +"', '"+ h.Number +"', '"+ h.Postal_code +"')";
            try
            { headquarter.Insert(query); return true; }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;   
            }
        }

        public List<Residence> getSingleUserResidence(int employee_id)
        {
            String query = "SELECT * FROM employee_residence WHERE employee_id = '" + employee_id + "'";
            List<Residence> result = residence.Select(query);
            return result;
        }

        public List<Residence> getSingleResidence(int residence_id)
        {
            String query = "SELECT * FROM employee_residence WHERE id = '" + residence_id + "'";
            List<Residence> result = residence.Select(query);

            return result;
        }

        public Boolean addResidence(Residence r)
        {
            String query = "INSERT INTO employee_residence(employee_id, country, city, street, number, postal_code, current_residence) VALUES('" + r.Employee_id + "', '" + r.Country + "', '" + r.City + "', '" + r.Street + "', '" + r.Number + "', '" + r.Postal_code + "', '" + r.Current_residence + "')";
            try
            { residence.Insert(query); return true; }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Boolean editResidence(Residence r, int residence_id)
        {
            //update hq id not implemented yet
            String query = "UPDATE employee_residence SET country = '" + r.Country + "', city = '" + r.City + "', street = '" + r.Street + "', number = '" + r.Number + "', postal_code = '" + r.Postal_code + "', current_residence = '" + r.Current_residence+ "' WHERE id = '" + residence_id + "'";
            try { residence.Insert(query); return true; }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
        }

        public Boolean deleteResidence(int residence_id)
        {
            String query = "DELETE FROM employee_residence WHERE id = '" + residence_id + "'";
            try { residence.Delete(query); return true; }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Degree> getSingleUserDegree(int employee_id)
        {
            String query = "SELECT * FROM degree AS d, degree_employee AS de WHERE de.employee_id = '" + employee_id + "' AND d.id = de.degree_id";
            List<Degree> result = degree.Select(query);
            return result;
        }

        public Boolean addDegree(Degree d, int employee_id)
        {
            String query = "INSERT INTO degree(course, school, level) VALUES('" + d.course + "', '" + d.school + "', '" + d.level + "')";
            String query_select = "SELECT * FROM degree WHERE course = '" + d.course + "' AND school = '" + d.school + "' AND level = '" + d.level + "'";
            try
            {
                degree.Insert(query);
                List<Degree> result = degree.Select(query_select);
                var degree_id = result[0].id;
                String query_connectTable = "INSERT INTO degree_employee(employee_id, degree_id) VALUES('" + employee_id + "', '" + degree_id + "')";
                degree_employee.Insert(query_connectTable);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Boolean editDegree(Degree d, int degree_id)
        {
            //update hq id not implemented yet
            String query = "UPDATE degree SET course = '" + d.course + "', school = '" + d.school + "', level = '" + d.level + "' WHERE id = '" + degree_id + "'";
            try { degree.Insert(query); return true; }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Boolean deleteDegree(int degree_id)
        {
            String query = "DELETE FROM degree WHERE id = '" + degree_id + "'";
            try { degree.Delete(query); return true; }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Degree> getSingleDegree(int degree_id)
        {
            String query = "SELECT * FROM degree WHERE id = '" + degree_id + "'";
            List<Degree> result = degree.Select(query);

            return result;
        }
    }
}
