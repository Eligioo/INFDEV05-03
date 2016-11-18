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
        private String headquarterId;

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

        public string HeadquarterId
        {
            get
            {
                return headquarterId;
            }

            set
            {
                headquarterId = value;
            }
        }

        public User(String id, String bsn, String name, String surname, String headquarterid) {
            this.Id = id;
            this.Bsn = bsn;
            this.Name = name;
            this.Surname = surname;
            this.HeadquarterId = headquarterid;
        }


    }
}
