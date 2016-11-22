using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Position : Object
    {
        private int id;
        private int employee_id;
        private string name;
        private string description;
        private int hour_fee;
        private int project_id;
        public Position()
        {
            this.id = Id;
            this.employee_id = Employee_id;
            this.name = Name;
            this.description = Description;
            this.hour_fee = Hour_fee;
            this.project_id = Project_id;
        }

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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int Hour_fee
        {
            get
            {
                return hour_fee;
            }

            set
            {
                hour_fee = value;
            }
        }

        public int Project_id
        {
            get
            {
                return project_id;
            }

            set
            {
                project_id = value;
            }
        }
    }
}
