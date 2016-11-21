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
    public partial class AddEditHeadquarter : Form
    {
        DBHelper db1 = new DBHelper();
        private int id;
        public AddEditHeadquarter(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Headquarter hqAdd = new Headquarter();
            hqAdd.Building_name = BuildingName.Text;
            hqAdd.Rooms = Int32.Parse(Rooms.Text);
            hqAdd.Rent = Int32.Parse(Rent.Text);
            hqAdd.Country = Country.Text;
            hqAdd.City = City.Text;
            hqAdd.Street = Street.Text;
            hqAdd.Number = Int32.Parse(Number.Text);
            hqAdd.Postal_code = PostalCode.Text;

            if (db1.addHeadquarter(hqAdd))
                this.Close();
            else
                MessageBox.Show("Headquarter couldn't be added!");
        }
    }
}
