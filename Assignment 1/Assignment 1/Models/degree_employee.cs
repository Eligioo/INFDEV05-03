using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Degree_employee : Object
    {
        private int Id;
        private int Employee_id;
        private int Degree_id;
        public Degree_employee()
        {
            this.Id = id;
            this.Employee_id = employee_id;
            this.Degree_id = degree_id;
        }

        public int id
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

        public int employee_id
        {
            get
            {
                return Employee_id;
            }

            set
            {
                Employee_id = value;
            }
        }

        public int degree_id
        {
            get
            {
                return Degree_id;
            }

            set
            {
                Degree_id = value;
            }
        }
    }
}
