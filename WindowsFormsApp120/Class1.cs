using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp120
{
    class cEmployee:IEmployee
    {

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Concatinate()
        {
            return FirstName + ' ' + LastName;
        }
    }
}
