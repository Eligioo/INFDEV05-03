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
    public partial class AddEditEmployee : Form
    {
        DBHelper db1 = new DBHelper();
        Assignment_1.User result;
        int employeeBsn;
        int employee_id;
        public AddEditEmployee(int employeeBsn)
        {
            this.employeeBsn = employeeBsn;
            InitializeComponent();
            if (employeeBsn != 0)
            {
                GetEmployeeData(employeeBsn);
            }
            Headquarter hq = new Headquarter();
            hq.Id = 2;
            hq.Building_name = "Harvard";

            comboBox1.DataSource = new BindingSource(db1.getHeadquarterList(), null);
            comboBox1.DisplayMember = "Building_name";
            comboBox1.ValueMember = "Id";
            degreeListBox.DataSource = new BindingSource(db1.getSingleUserDegree(employee_id), null);
            degreeListBox.DisplayMember = "course";
            degreeListBox.ValueMember = "id";
            

            //residenceListbox.DataSource = new BindingSource()
            //comboBox1.Items.Add(hq);
        }

        private void GetEmployeeData(int employeeBsn)
        {
            result = db1.getSingleUser(employeeBsn)[0];
            name.Text = result.Name.TrimEnd();
            surname.Text = result.Surname.TrimEnd();
            bsn.Text = result.Bsn.ToString().TrimEnd();
            this.employee_id = result.Id;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            User u = new Assignment_1.User();
            u.Bsn = Int32.Parse(bsn.Text);
            u.Name = name.Text;
            u.Surname = surname.Text;
            u.Id = 0;
            if (comboBox1.SelectedValue != null)
            {
                u.Headquarter_Id = Int32.Parse(comboBox1.SelectedValue);
            }
            if (employeeBsn == 0)
            {
                db1.addUser(u);
            }
            else
            {
                db1.editUser(u, employeeBsn);
            }
            this.Close();
            MessageBox.Show("Changes have been made.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditResidence AddEditResidence = new AddEditResidence(employee_id, 0);
            AddEditResidence.Show();
        }

        private void AddEditEmployee_Activated(object sender, EventArgs e)
        {
            var residences = db1.getSingleUserResidence(employee_id);
            var current_residence = new Residence();
            residenceListbox.DataSource = new BindingSource(residences, null);
            residenceListbox.DisplayMember = "Street";
            residenceListbox.ValueMember = "Id";
            degreeListBox.DataSource = new BindingSource(db1.getSingleUserDegree(employee_id), null);
            degreeListBox.DisplayMember = "course";
            degreeListBox.ValueMember = "id";
            foreach (var residence in residences)
            {
                if (residence.Current_residence == true)
                {
                    current_residence = residence;
                }
            }

            if (employeeBsn != 0)
            {
                residenceListbox.SelectedItem = current_residence;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (residenceListbox.SelectedItems.Count == 1)
            {
                int residence_id = int.Parse(residenceListbox.SelectedValue.ToString());
                var residences = db1.getSingleUserResidence(employee_id);
                foreach (var residence in residences)
                {
                    if (int.Parse(residenceListbox.SelectedValue.ToString()) != residence.Id)
                    {
                        residence.Current_residence = false;
                    }
                    else
                    {
                        residence.Current_residence = true;
                    }
                    db1.editResidence(residence, residence.Id);
                }
            }
            else
                MessageBox.Show("Select a residence.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (residenceListbox.SelectedItems.Count == 1)
            {
                int residence_id = int.Parse(residenceListbox.SelectedValue.ToString());
                AddEditResidence AddEditResidence = new AddEditResidence(employee_id, residence_id);
                AddEditResidence.Show();
            }
            else
                MessageBox.Show("Select a residence.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (residenceListbox.SelectedItems.Count == 1)
            {
                db1.deleteResidence(int.Parse(residenceListbox.SelectedValue.ToString()));
            }
            else
            {
                MessageBox.Show("Select a residence.");
            }
        }

        private void addDegreeButton_Click(object sender, EventArgs e)
        {
            AddEditDegree AddEditDegree = new AddEditDegree(employee_id, 0);
            AddEditDegree.Show();
        }

        private void editDegreeButton_Click(object sender, EventArgs e)
        {
            if (degreeListBox.SelectedItems.Count == 1)
            {
                AddEditDegree AddEditDegree = new AddEditDegree(employee_id, int.Parse(degreeListBox.SelectedValue.ToString()));
                AddEditDegree.Show();
            }
            else
            {
                MessageBox.Show("Select a degree");
            }
        }

        private void deleteDegreeButton_Click(object sender, EventArgs e)
        {
            var degree_id = int.Parse(degreeListBox.SelectedValue.ToString());
            if (db1.deleteDegree(degree_id))
            {
                MessageBox.Show("Degree has been deleted");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
