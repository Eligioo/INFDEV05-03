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
    public partial class AddEditResidence : Form
    {
        DBHelper db1 = new DBHelper();
        int residence_id;
        int employee_id;
        public AddEditResidence(int employee_id, int residence_id)
        {
            this.residence_id = residence_id;
            this.employee_id = employee_id;
            InitializeComponent();
            
            if (residence_id != 0)
            {
                GetResidenceData();
            }
        }

        private void GetResidenceData()
        {
            var result = db1.getSingleResidence(this.residence_id)[0];
            textBox_city.Text = result.City.TrimEnd();
            textBox_country.Text = result.Country.TrimEnd();
            textBox_postalcode.Text = result.Postal_code.TrimEnd();
            textBox_street.Text = result.Street.TrimEnd();
            textBox_housenr.Text = result.Number.ToString().TrimEnd();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Residence residence = new Residence();
            residence.Employee_id = employee_id;
            residence.City = textBox_city.Text;
            residence.Street = textBox_street.Text;
            residence.Country = textBox_city.Text;
            residence.Postal_code = textBox_postalcode.Text;
            residence.Number = int.Parse(textBox_housenr.Text);
            if (residence_id == 0)
            {
                db1.addResidence(residence);
            }
            else
            {
                db1.editResidence(residence, residence_id);
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditResidence_Activated(object sender, EventArgs e)
        {
            if (residence_id != 0)
            {
                GetResidenceData();
            }
        }
    }
}
