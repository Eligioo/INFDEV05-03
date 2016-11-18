using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Models
{
    class Headquarter : Object
    {
        private int id;

        private String bsn;
        private String building_name;

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
        public Headquarter()
        {
            this.Id = Id;
            this.Building_name = Building_name;
        }


    }
}
