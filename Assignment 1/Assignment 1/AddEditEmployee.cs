using Assignment_1.Models;
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
        DatabaseClassesDataContextDataContext db = new DatabaseClassesDataContextDataContext();
        Assignment_1.employee result;
        int employeeBsn;
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
            //comboBox1.Items.Add(hq);
        }

        private void GetEmployeeData(int employeeBsn)
        {
            var employee =
                    from e in db.employees
                    where e.bsn == employeeBsn
                    select e;
            result = employee.First();
            name.Text = result.name.TrimEnd();
            surname.Text = result.surname.TrimEnd();
            bsn.Text = result.bsn.ToString().TrimEnd();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (employeeBsn == 0)
            {
                User u = new Assignment_1.User();
                u.Bsn = bsn.Text;
                u.Name = name.Text;
                u.Surname = surname.Text;
                u.Id = null;
                u.Headquarter_Id = comboBox1.SelectedValue.ToString();
                db1.addUser(u);
                this.Close();
                MessageBox.Show("Changes have been made.");
            }
            else
            {
                var current_bsn = employeeBsn;
                User u = new Assignment_1.User();
                u.Bsn = bsn.Text;
                u.Name = name.Text;
                u.Surname = surname.Text;
                u.Id = null;
                u.Headquarter_Id = comboBox1.SelectedValue.ToString();
                db1.editUser(u, employeeBsn);
                this.Close();
                MessageBox.Show("Changes have been made.");
            }
        }
    }
}
