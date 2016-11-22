using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Degree : Object
    {
        private int Id;
        private string School;
        private string Level;
        private string Course;
        public Degree()
        {
            this.Id = id;
            this.School = school;
            this.Level = level;
            this.Course = course;
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

        public string school
        {
            get
            {
                return School;
            }

            set
            {
                School = value;
            }
        }

        public string level
        {
            get
            {
                return Level;
            }

            set
            {
                Level = value;
            }
        }

        public string course
        {
            get
            {
                return Course;
            }

            set
            {
                Course = value;
            }
        }
    }
}
