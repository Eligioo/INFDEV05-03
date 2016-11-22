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
        DatabaseClassesDataContextDataContext db = new DatabaseClassesDataContextDataContext();
        DBHelper db1 = new DBHelper();
        public Form1()
        {
            InitializeComponent();
            //db1.getAllUsers();
            GetEmployeesListbox();
            GetProjectsListbox();
            GetPositionsListbox();
            db1.getAllProjects();
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
            var employees = db1.getAllUsers();
            foreach (var item in employees)
            {
                EmployeesListBox.Items.AddRange(new object[] { item.Name  + " " + item.Surname  + " " + item.Bsn });
            }
        }

        private void GetProjectsListbox()
        {
            var projects = db1.getAllProjects();
            foreach (var item in projects)
            {
                ProjectsListBox.Items.AddRange(new object[] { item.Name + " "+ item.Id });
            }
        }

        private void GetPositionsListbox()
        {
            var positions = db1.getAllPositions();
            PositionsListBox.DataSource = new BindingSource(positions, null);
            PositionsListBox.DisplayMember = "name";
            PositionsListBox.ValueMember = "id";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            EmployeesListBox.Items.Clear();
            GetEmployeesListbox();

            ProjectsListBox.Items.Clear();
            GetProjectsListbox();

            GetPositionsListbox();
        }

        private void EmployeesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteEmployeBtn_Click(object sender, EventArgs e)
        {
            if (EmployeesListBox.SelectedItems.Count == 1)
            {
                string item = EmployeesListBox.SelectedItem.ToString();
                string bsn = item.Substring(item.Length - 6);
                db1.deleteUser(Int32.Parse(bsn));
                MessageBox.Show("Employee deleted");
                Form1_Activated(sender, e);
            }
            else
                MessageBox.Show("Select a person.");
        }

        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            AddEditProject AddEditProject = new AddEditProject(0);
            AddEditProject.Show();
        }

        private void EditProjectBtn_Click(object sender, EventArgs e)
        {
            if (ProjectsListBox.SelectedItems.Count == 1)
            {
                string item = ProjectsListBox.SelectedItem.ToString();
                int id = Int32.Parse(item.Split(' ').Last());
                AddEditProject AddEditProject = new AddEditProject(id);
                AddEditProject.Show();
            }
            else
                MessageBox.Show("Select a project");
        }

        private void DeleteProjectBtn_Click(object sender, EventArgs e)
        {
            if (ProjectsListBox.SelectedItems.Count == 1)
            {
                string item = ProjectsListBox.SelectedItem.ToString();
                int id = Int32.Parse(item.Split(' ').Last());
                if (db1.deleteProject(id))
                {
                    MessageBox.Show("Project deleted.");
                }
                else
                    MessageBox.Show("Something went wrong!");


            }
            else
                MessageBox.Show("Select a project.");
        }

        private void positionAddButton_Click(object sender, EventArgs e)
        {
            AddEditPosition AddEditPosition = new AddEditPosition(0);
            AddEditPosition.Show();
        }

        private void positionEditButton_Click(object sender, EventArgs e)
        {
            if (PositionsListBox.SelectedItems.Count == 1)
            {
                int position_id = int.Parse(PositionsListBox.SelectedValue.ToString());
                AddEditPosition AddEditPosition = new AddEditPosition(position_id);
                AddEditPosition.Show();
            }
            else
                MessageBox.Show("Select a position");
        }

        private void positionDeleteButton_Click(object sender, EventArgs e)
        {
            if (PositionsListBox.SelectedItems.Count == 1)
            {
                int position_id = int.Parse(PositionsListBox.SelectedValue.ToString());
                if (db1.deletePosition(position_id))
                {
                    MessageBox.Show("Position deleted.");
                }
                else
                    MessageBox.Show("Something went wrong!");
            }
            else
                MessageBox.Show("Select a position.");
        }
    }
}
