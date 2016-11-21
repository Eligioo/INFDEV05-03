using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Headquarter : Object
    {
        private int id;
        private String building_name;
        private int rooms;
        private float rent;
        private String country;
        private String city;
        private String street;
        private int number;
        private String postal_code;

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

        public string Building_name
        {
            get
            {
                return building_name;
            }

            set
            {
                building_name = value;
            }
        }

        public int Rooms
        {
            get
            {
                return rooms;
            }

            set
            {
                rooms = value;
            }
        }

        public float Rent
        {
            get
            {
                return rent;
            }

            set
            {
                rent = value;
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

        public Headquarter()
        {
            this.id = Id;
            this.building_name = Building_name;
            this.rooms = Rooms;
            this.rent = Rent;
            this.country = Country;
            this.city = City;
            this.street = Street;
            this.number = Number;
            this.postal_code = Postal_code;
        }
    }
}
