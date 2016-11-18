﻿using Assignment_1.Models;
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
        Assignment_1.User result;
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

            //residenceListbox.DataSource = new BindingSource()
            //comboBox1.Items.Add(hq);
        }

        private void GetEmployeeData(int employeeBsn)
        {
            result = db1.getSingleUser(employeeBsn)[0];
            name.Text = result.Name.TrimEnd();
            surname.Text = result.Surname.TrimEnd();
            bsn.Text = result.Bsn.ToString().TrimEnd();
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (residenceListbox.SelectedItems.Count == 1)
            {
                string item = residenceListbox.SelectedItem.ToString();
                string bsn = item.Substring(item.Length - 6);
                //AddEditEmployee AddEditEmployee = new AddEditEmployee(Int32.Parse(bsn));
                //AddEditEmployee.Activated += AddEditEmployee_Activated;
                //AddEditEmployee.Show();
            }
            else
                MessageBox.Show("Select a person.");
        }

        private void SetBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
