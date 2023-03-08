using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJS.AutoRepair.BL.Test
{
    [TestClass]
    public class CustomerCollectiontest
    {
        [TestMethod]
        public void CustomerCollectionLoadTest()
        {
            CustomerCollection customercollecton = new CustomerCollection();

            customercollecton.LoadTestCustomers();

            Thread.Sleep(2000);

            //for stopwatch, make sure that it is not 00:00:00 after it sleeps. giving it time and all to catch up.


            //creating a test layer is amazing and makes programming great.

            //

            //Assert.IsTrue(customercollecton.Count > 0);
            if (customercollecton.Count == 0) Assert.Fail();
        }
    }
}
