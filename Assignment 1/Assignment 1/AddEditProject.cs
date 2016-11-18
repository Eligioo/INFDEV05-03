using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class AddEditProject : Form
    {
        DBHelper db1 = new DBHelper();
        Assignment_1.Project result;
        private int projectId;

        public AddEditProject(int projectId)
        {
            InitializeComponent();
            this.projectId = projectId;
            if (this.projectId != 0)
            {
                GetProjectData(projectId);
            }
        }

        public void GetProjectData(int projectId)
        {
            result = db1.getSingleProject(projectId)[0];
            projectTextBox.Text = result.Name.Trim();
            budgetTextBox.Text = result.Buget.ToString().Trim();
            allocatedHoursTextBox.Text = result.Allocated_hours.ToString().Trim();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //Save Button
        //NOTE: hq id always 0 for now
        private void button1_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.Name = projectTextBox.Text;
            p.Buget = float.Parse(budgetTextBox.Text);
            p.Allocated_hours = float.Parse(allocatedHoursTextBox.Text);
            p.Headquarters_Id = 0;
            if (projectId == 0)
            {
                if (db1.addProject(p))
                {
                    MessageBox.Show("Project added");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Adding went wrong.");
                }
            }
            else
            {
                if (db1.editProject(p, projectId))
                {
                    MessageBox.Show("Project is edited.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Editing went wrong.");
                }
            }
        }
    }
}
