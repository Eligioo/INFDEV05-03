using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        DatabaseClassesDataContextDataContext db = new DatabaseClassesDataContextDataContext();
        public Form1()
        {
            InitializeComponent();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"D:\GitHub\INFDEV03-5\Assignment 1\Assignment 1\assignment1.mdf" + @";Integrated Security=True";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                GetEmployeesListbox();
                GetProjectsListbox();

                connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
                //MessageBox.Show("Can't connect to database!");
            }
        }

        private void EditEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (EmployeesListBox.SelectedItems.Count == 1)
            {
                string item = EmployeesListBox.SelectedItem.ToString();
                string bsn = item.Substring(item.Length - 6);
                AddEditEmployee AddEditEmployee = new AddEditEmployee(Int32.Parse(bsn));
                AddEditEmployee.Activated += AddEditEmployee_Activated;
                AddEditEmployee.Show();
            }
            else
                MessageBox.Show("Select a person.");
        }

        private void AddEditEmployee_Activated(object sender, EventArgs e)
        {
            EmployeesListBox.Items.Clear();
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEditEmployee AddEditEmployee = new AddEditEmployee(0);
            AddEditEmployee.Show();
        }

        private void GetEmployeesListbox()
        {
            var employees = from a in db.employees select a;
            foreach (var item in employees)
            {
                EmployeesListBox.Items.AddRange(new object[] { item.name + " " + item.surname + " " + item.bsn.ToString() });
            }
        }

        private void GetProjectsListbox()
        {
            var projects =
                   from p in db.projects
                   join h in db.headquarters
                   on p.headquarters_id equals h.id
                   into a
                   from b in a.DefaultIfEmpty()
                   select new
                   {
                       p.name,
                       b.building_name
                   };
            foreach (var item in projects)
            {
                ProjectsListBox.Items.AddRange(new object[] { item.name + " " + item.building_name });
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            EmployeesListBox.Items.Clear();
            GetEmployeesListbox();
        }
    }
}
