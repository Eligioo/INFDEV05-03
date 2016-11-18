using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Project : Object
    {
        private int id;

        private String name;
        private float buget;
        private float allocated_hours;
        private int headquarters_id;

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

        public String Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float Buget
        {
            get
            {
                return buget;
            }

            set
            {
                buget = value;
            }
        }

        public float Allocated_hours
        {
            get
            {
                return allocated_hours;
            }

            set
            {
                allocated_hours = value;
            }
        }

        public int Headquarters_Id
        {
            get
            {
                return headquarters_id;
            }

            set
            {
                headquarters_id = value;
            }
        }

        public Project()
        {
            this.Id = Id;
            this.Name = Name;
            this.Buget = Buget;
            this.Allocated_hours = Allocated_hours;
            this.Headquarters_Id = Headquarters_Id;
        }


    }
}
