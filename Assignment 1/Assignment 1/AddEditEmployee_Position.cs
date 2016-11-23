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
    
    public partial class AddEditEmployee_Position : Form
    {
        DBHelper db = new DBHelper();
        private int position_id;
        private int project_id;
        public AddEditEmployee_Position(int position_id, int project_id)
        {
            InitializeComponent();
            this.position_id = position_id;
            this.project_id = project_id;
            if (this.position_id != 0)
            {
                //this.current_position = db.getSinglePosition(position_id)[0];
                getPositionData();
            }
        }

        private void getPositionData()
        {
            var result = db.getSinglePosition(position_id)[0];
            textBox_name.Text = result.Name.TrimEnd();
            textBox_description.Text = result.Description.TrimEnd();
            textBox_hour_fee.Text = result.Hour_fee.ToString();

            var all_users = db.getAllUsersExceptCurrentPosition(project_id, position_id);
            var position_users = db.getSingleProjectPositionEmployees(project_id, position_id);

            listBox1.DataSource = position_users;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";


            listBox2.DataSource = all_users;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "Id";
        }

        private void AddEditEmployee_Position_Activated(object sender, EventArgs e)
        {
            if (this.position_id != 0)
            {
                getPositionData();
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 1)
            {
                Employee_project_position userPosition = new Employee_project_position();
                userPosition.Employee_id = int.Parse(listBox2.SelectedValue.ToString());
                userPosition.Position_id = position_id;
                userPosition.Project_id = project_id;

                db.addUserPosition(userPosition);
            }
            else
            {
                MessageBox.Show("Select an employee");
            }
            
            getPositionData();
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                db.deleteUserPosition(project_id, int.Parse(listBox1.SelectedValue.ToString()), position_id);
            }
            else
            {
                MessageBox.Show("Select an employee");
            }

            getPositionData();
        }

        private void savePositionButton_Click(object sender, EventArgs e)
        {
            Position position = new Position();
            position.Name = textBox_name.Text;
            position.Description = textBox_description.Text;
            position.Hour_fee = int.Parse(textBox_hour_fee.Text);
            if (position_id == 0)
            {
                db.addPosition(position, project_id);
            }
            else
            {
                db.editPosition(position, position_id);
            }
            this.Close();
        }

        private void cancelPositionButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
