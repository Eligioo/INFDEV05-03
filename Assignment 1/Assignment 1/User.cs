using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class User : Object
    {
        private String id;

        private String bsn;
        private String name;
        private String surname;
        private String headquarter_Id;

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

        public string Bsn
        {
            get
            {
                return bsn;
            }

            set
            {
                bsn = value;
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

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string Headquarter_Id
        {
            get
            {
                return headquarter_Id;
            }

            set
            {
                headquarter_Id = value;
            }
        }

        public User() {
            this.Id = Id;
            this.Bsn = Bsn;
            this.Name = Name;
            this.Surname = Surname;
            this.Headquarter_Id = Headquarter_Id;
        }


    }
}
