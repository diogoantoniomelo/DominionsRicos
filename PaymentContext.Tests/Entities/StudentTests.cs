using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]

    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var student = new Student("Diogo", "Melo","143432432","diogo@diogo.com");
        }    
    }
}