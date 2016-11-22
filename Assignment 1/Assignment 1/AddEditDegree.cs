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
    public partial class AddEditDegree : Form
    {
        DBHelper db = new DBHelper();
        private int employee_id;
        private int degree_id;
        public AddEditDegree(int employee_id, int degree_id)
        {
            this.employee_id = employee_id;
            this.degree_id = degree_id;
            InitializeComponent();

            if (degree_id != 0)
            {
                getDegreeData(employee_id, degree_id);
            }
        }

        private void getDegreeData(int employee_id, int degree_id)
        {
            var result = db.getSingleDegree(this.degree_id)[0];
            textBox_course.Text = result.course.TrimEnd();
            textBox_school.Text = result.school.TrimEnd();
            textBox_level.Text = result.level.TrimEnd();
        }

        private void saveDegreeButton_Click(object sender, EventArgs e)
        {
            Degree degree = new Degree();
            degree.course = textBox_course.Text;
            degree.school = textBox_school.Text;
            degree.level = textBox_level.Text;
            if (degree_id == 0)
            {
                db.addDegree(degree, employee_id);
            }
            else
            {
                db.editDegree(degree, degree_id);
            }
            
            this.Close();
        }

        private void cancelDegreeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditDegree_Activated(object sender, EventArgs e)
        {
            if (degree_id != 0)
            {
                getDegreeData(employee_id, degree_id);
            }
            
        }
    }
}
