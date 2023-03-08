using AJS.AutoRepair.BL;

namespace AJS.AutoRepair.UI
{
//Pillars of OOP
//Encapsulation -- package up related data and methods.
//Inheritance -- getting shit for free.
//Polymorphism -- 
//Abstraction -- Don't need to know the details regarding.

    public partial class Form1 : Form
    {

        //fields:
        //Here below, we are creating a list of customers in order to create, keep track of past customers.
        private CustomerCollection customers = new CustomerCollection();

        private DateTime startTime = DateTime.MinValue;
        public Form1()
        {
            InitializeComponent();

            customers.LoadTestCustomers();
            //using an interface to sort our customers.
            customers.Sort();

            RebindCustomers();

            startTime = DateTime.Now;
            staTime.Text = "00:00:00";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();

            cust.FirstName = txtFirstName.Text;
            cust.LastName = txtLastName.Text;   
            cust.PhoneNumber = txtPhoneNumber.Text;

            //Adding the current customer above to the list of customers.
            customers.Add(cust);

            //using a interface to sort the customers, (agreed on contract)
            customers.Sort();

            //Binding data from the list to the lstbox table for display or show.

            RebindCustomers();
        }
        private void RebindCustomers()
        {
            lstCustomers.DataSource = null; //unbind
            lstCustomers.DataSource = customers; //re-bind

        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer? selectedCustomer = lstCustomers.SelectedItem as Customer;
            
            if (selectedCustomer != null)
            {
                txtFirstName.Text = selectedCustomer.FirstName;
                txtLastName.Text = selectedCustomer.LastName;
                txtPhoneNumber.Text = selectedCustomer.PhoneNumber;

                RebindVehicles(selectedCustomer.Vehicles);
            }
        }

        private void RebindVehicles(List<Vehicle> vehicles)
        {
            lstVehicles.DataSource = null;
            lstVehicles.DataSource = vehicles;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            //staTime.Text = DateTime.Now.ToString("h\\:mm\\:ss");

            TimeSpan sinceStart = DateTime.Now - startTime;
            staTime.Text = sinceStart.ToString("h\\:mm\\:ss");
        }
    }
}