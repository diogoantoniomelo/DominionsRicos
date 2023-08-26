[TestClass]
public class SubscriptionHandlerTests
{
    // Red, Green, Refactor

    [TestMethod]
    public void ShouldReturnErrorWhenDocumentExists()
    {
        var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
        var command = new CreateBoletoSubscriptionCommand();
        command.FirstName = "Rogerio";
        command.LastName = "Ceni";
        command.Document = "99999999999";
        command.Email = "hello@diogo.io";
        command.BarCode = "123456789";
        command.BoletoNumber = "1234654987";
        command.PaymentNumber = "123121";
        command.PaidDate = DateTime.Now;
        command.ExpireDate = DateTime.Now.AddMonths(1);
        command.Total = 60;
        command.TotalPaid = 60;
        command.Payer = "SPFC";
        command.PayerDocument = "12345678911";
        command.PayerDocumentType = EDocumentType.CPF;
        command.PayerEmail = "mito@spfc.com";
        command.Street = "asdas";
        command.Number = "asdd";
        command.Neighborhood = "asdasd";
        command.City = "as";
        command.State = "as";
        command.Country = "as";
        command.ZipCode = "12345678";

        handler.Handle(command);
        Assert.AreEqual(false, handler.IsValid);
    }
}
