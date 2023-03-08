using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJS.AutoRepair.BL
{
    public class Person
    {
        //Creating properties to create a Customer.
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        protected DateTime DOB { get; set; }

        //method to get the full name.
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        //methods.
        public override string ToString()
        {
            return FullName;
        }
    }
}
