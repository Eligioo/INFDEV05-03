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
        public AddEditEmployee(int employeeBsn)
        {
            InitializeComponent();
            if (employeeBsn == 0)
            {
                throw new NotImplementedException("Add employee");
            }
            else
                GetEmployeeData(employeeBsn);
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
            User u = new Assignment_1.User(null, bsn.Text, name.Text, surname.Text, null);
            db1.addUser(u);
            this.Close();
            MessageBox.Show("Changes have been made.");
        }
    }
}
