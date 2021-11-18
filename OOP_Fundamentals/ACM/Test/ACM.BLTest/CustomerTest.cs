using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestCustomerFullName()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Kyle";
            customer.LastName = "Hayden";


            //-- Act



            //-- Assert

        }
    }
}
