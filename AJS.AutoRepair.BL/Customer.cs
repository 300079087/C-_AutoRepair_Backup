using AJS.AutoRepair.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJS.AutoRepair.BL
{
    //an interface is a promise that we will do something. (a contract)
    public class Customer : Person, IComparable<Customer>
    {

        public string PhoneNumber { get; set; } = "";

        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();


        public Customer()
        {
            FirstName = "Ryan";
            DOB = new DateTime(1983, 6, 17);
        }

        public int CompareTo(Customer? other)
        {
            if (LastName.CompareTo(other!.LastName) == 0)
            {
                return FirstName.CompareTo(other.FirstName);
            }

            return LastName.CompareTo(other.LastName);
            

        }
    }
}
