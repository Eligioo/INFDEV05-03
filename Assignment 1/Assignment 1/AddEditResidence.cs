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
        int employeeBsn;
        public AddEditResidence(int employeeBsn, int residence_id)
        {
            this.residence_id = residence_id;
            InitializeComponent();
            GetResidenceData(employeeBsn);
        }

        private void GetResidenceData(int employeeBsn)
        {
            var result = db1.getSingleUserResidence(residence_id)[0];
            textBox_city.Text = result.City.TrimEnd();
            textBox_country.Text = result.Country.TrimEnd();
            textBox_postalcode.Text = result.Postal_code.TrimEnd();
            textBox_street.Text = result.Street.TrimEnd();
            textBox_housenr.Text = result.Number.ToString().TrimEnd();
        }
    }
}
