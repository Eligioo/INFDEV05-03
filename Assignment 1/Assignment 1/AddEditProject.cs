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
        List<Headquarter> hqList = new List<Headquarter>();
        private int projectId;

        public AddEditProject(int projectId)
        {
            InitializeComponent();
            this.projectId = projectId;
            if (this.projectId != 0)
            {
                GetProjectData(projectId);
            }
            GetHeadquartersData();
            GetPositionsData();
        }

        public void GetProjectData(int projectId)
        {
            result = db1.getSingleProject(projectId)[0];
            projectTextBox.Text = result.Name.Trim();
            budgetTextBox.Text = result.Buget.ToString().Trim();
            allocatedHoursTextBox.Text = result.Allocated_hours.ToString().Trim();
        }

        public void GetHeadquartersData()
        {
            Headquarter hq = new Headquarter();
            hqList = db1.getHeadquarterList();
            comboBox1.DataSource = new BindingSource(hqList, null);
            comboBox1.DisplayMember = "Building_name";
            comboBox1.ValueMember = "Id";
            if (this.projectId != 0)
            {
                comboBox1.SelectedValue = result.Headquarters_Id;
            }
        }

        private void GetPositionsData()
        {
            if (projectId != 0)
            {
                var result = db1.getSingleProjectPositions(this.projectId);
                listBox_positions.DataSource = new BindingSource(result, null);
                listBox_positions.DisplayMember = "Name";
                listBox_positions.ValueMember = "Id";
            }
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
            p.Headquarters_Id = Int32.Parse(comboBox1.SelectedValue.ToString());
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

        private void button3_Click(object sender, EventArgs e)
        {
            AddEditHeadquarter AddEditHeadquarter = new AddEditHeadquarter(0);
            AddEditHeadquarter.Show();
        }

        private void AddEditProject_Activated(object sender, EventArgs e)
        {
            GetHeadquartersData();
            GetPositionsData();
        }

        private void AddPositionButton_Click(object sender, EventArgs e)
        {
            AddEditEmployee_Position AddEditEmployee_Position = new AddEditEmployee_Position(0, projectId);
            AddEditEmployee_Position.Show();
        }

        private void editPositionButton_Click(object sender, EventArgs e)
        {
            if (listBox_positions.SelectedItems.Count != 0)
            {
                AddEditEmployee_Position AddEditEmployee_Position = new AddEditEmployee_Position(int.Parse(listBox_positions.SelectedValue.ToString()), projectId);
                AddEditEmployee_Position.Show();
            }
        }

        private void deletePositionButton_Click(object sender, EventArgs e)
        {
            db1.deletePosition(int.Parse(listBox_positions.SelectedValue.ToString()));
            MessageBox.Show("The position has been deleted");
        }
    }
}
