using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        private readonly Student _student;
        private readonly Subscription _subscription;
        private readonly Name _name;
        private readonly Email _email;
        private readonly Document _document;
        private readonly Address _address;

        public StudentTests()
        {
            _name = new Name("Rogerio", "Ceni");
            _document = new Document("12343216834", EDocumentType.CPF);
            _email = new Email("mito@spfc.com");
            _address = new Address("Rua mito", "100", "São Paulo", "São Paulo", "SP", "BR", "663");
            _student = new Student(_name, _document, _email);
            _subscription = new Subscription(null);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var payment = new PayPalPayment(
                "19827398127398",
                DateTime.Now,
                DateTime.Now.AddDays(5),
                10,
                10,
                "SPFC",
                _document,
                _address,
                _email
            );
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
            _student.AddSubscription(_subscription);
            Assert.IsFalse(_subscription.IsValid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadSubscriptionHasNoPayment()
        {
            _student.AddSubscription(_subscription);
            Assert.IsFalse(_subscription.IsValid);
        }

        public void ShouldReturnSuccessWhenHadAddSubscription()
        {
            var payment = new PayPalPayment(
                "19827398127398",
                DateTime.Now,
                DateTime.Now.AddDays(5),
                10,
                10,
                "SPFC",
                _document,
                _address,
                _email
            );
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
            Assert.IsTrue(_subscription.IsValid);
        }
    }
}
