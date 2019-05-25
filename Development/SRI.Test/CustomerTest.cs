using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sri.BL;

namespace SRI.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestFullName()
        {
            Customer customer = new Customer(1)
            {
                FirstName = "Srikanth",
                LastName = "Nimmagadda",
                EmailAddress = "XXX@GMAIL.COM"
            };

            string actual = customer.FullName;
            string expected = "Srikanth, Nimmagadda";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInstanceCount()
        {
            Customer customer = new Customer(1)
            {
                FirstName = "Srikanth",
                LastName = "Nimmagadda",
                EmailAddress = "XXX@GMAIL.COM"
            };
            Customer.InstanceCount += 1;

            Customer customerTwo = new Customer(2)
            {
                FirstName = "Sri",
                LastName = "Nimmagadda",
                EmailAddress = "XXX@GMAIL.COM"
            };
            Customer.InstanceCount += 1;

            Customer customerThree = new Customer
            {
                FirstName = "Srikanth",
                LastName = "Sri",
                EmailAddress = "XXX@GMAIL.COM"
            };
            Customer.InstanceCount += 1;

            int actualCount = 3;
            int expectedCount = Customer.InstanceCount;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void ValidateCustomerTest()
        {
            Customer customer = new Customer
            {
                FirstName = "Srikanth",
                LastName = "Sri",
                EmailAddress = "XXX@GMAIL.COM"
            };

            bool expected = true;
            bool actual = customer.Validate();

            Assert.AreEqual(expected, actual);

            Customer customerTwo = new Customer
            {
                FirstName = " ",
                LastName = string.Empty,
                EmailAddress = "XXX@GMAIL.COM"
            };

            Assert.AreEqual(false, customerTwo.Validate());
        }
    }
}
