using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Project : Object
    {
        private String id;

        private String name;
        private String buget;
        private String allocated_hours;
        private String headquarters_id;

        public string Id
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

        public string Name
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

        public string Buget
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

        public string Allocated_hours
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

        public string Headquarters_Id
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
