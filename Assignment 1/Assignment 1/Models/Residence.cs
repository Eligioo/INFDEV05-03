using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Residence : Object
    {
        private int id;
        private int employee_id;
        private string country;
        private string city;
        private string street;
        private int number;
        private string postal_code;
        private string current_residence;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Employee_id
        {
            get
            {
                return employee_id;
            }

            set
            {
                employee_id = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }

            set
            {
                street = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public string Postal_code
        {
            get
            {
                return postal_code;
            }

            set
            {
                postal_code = value;
            }
        }

        public string Current_residence
        {
            get
            {
                return current_residence;
            }

            set
            {
                current_residence = value;
            }
        }

        public Residence()
        {
            this.Id = Id;
            this.Employee_id = Employee_id;
            this.Country = Country;
            this.City = City;
            this.Street = Street;
            this.Number = Number;
            this.Postal_code = Postal_code;
            this.Current_residence = Current_residence;
        }
    }
}
