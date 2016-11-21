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

            comboBox1.DataSource = new BindingSource(hq, null);
            comboBox1.DisplayMember = "Building_name";
            comboBox1.ValueMember = "Id";

            //residenceListbox.DataSource = new BindingSource()
            //comboBox1.Items.Add(hq);
        }

        private void GetEmployeeData(int employeeBsn)
        {
            result = db1.getSingleUser(employeeBsn)[0];
            name.Text = result.Name.TrimEnd();
            surname.Text = result.Surname.TrimEnd();
            bsn.Text = result.Bsn.ToString().TrimEnd();
            this.employee_id = int.Parse(result.Id);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            User u = new Assignment_1.User();
            u.Bsn = bsn.Text;
            u.Name = name.Text;
            u.Surname = surname.Text;
            u.Id = null;
            if (comboBox1.SelectedValue != null)
            {
                u.Headquarter_Id = comboBox1.SelectedValue.ToString();
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
            residenceListbox.DataSource = new BindingSource(db1.getSingleUserResidence(employee_id), null);
            residenceListbox.DisplayMember = "Street";
            residenceListbox.ValueMember = "Id";
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
                        residence.Current_residence = "False";
                    }
                    else
                    {
                        residence.Current_residence = "True";
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
            db1.deleteResidence(int.Parse(residenceListbox.SelectedValue.ToString()));
        }
    }
}
