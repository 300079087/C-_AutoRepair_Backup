using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJS.AutoRepair.BL
{
    public class CustomerCollection : List<Customer>
    {
        public void LoadTestCustomers()
        {
            Customer customer;
            Vehicle car;

            customer = new Customer();
            customer.FirstName = "Ryan";
            customer.LastName = "Appel";
            customer.PhoneNumber = "1234567890";
            customer.Vehicles.Add(new Vehicle("Maserati", "Mc20", 2022));
            customer.Vehicles.Add(new Vehicle("Chevy", "Camaro", 2021));
            Add(customer);

            customer = new Customer();
            customer.FirstName = "Mommy";
            customer.LastName = "Appel";
            customer.PhoneNumber = "9876543210";
            customer.Vehicles.Add(new Vehicle("Toyota", "4 Runner", 2022));
            customer.Vehicles.Add(new Vehicle("Ford", "Maverick", 2021));
            Add(customer);

            customer = new Customer();
            customer.FirstName = "Daddy";
            customer.LastName = "Appel";
            customer.PhoneNumber = "4567893210";
            customer.Vehicles.Add(new Vehicle("Mini", "Cooper", 2022));
            customer.Vehicles.Add(new Vehicle("Ford", "Maverick", 2021));
            Add(customer);

        }
    }
}
