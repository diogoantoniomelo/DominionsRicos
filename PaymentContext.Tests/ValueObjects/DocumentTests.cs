namespace PaymentContext.Tests;

[TestClass]
public class DocumentTests
{
    public void ShouldReturnErrorWhenCNPJIsInvalid()
    {
        var doc = new Document("123", EDocumentType.CNPJ);
        Assert.IsFalse(doc.IsValid);
    }

    [TestMethod]
    [DataTestMethod]
    [DataRow("12345678912345")]
    [DataRow("12345678345345")]
    public void ShouldReturnSuccessWhenCNPJIsValid(string cnpj)
    {
        var doc = new Document(cnpj, EDocumentType.CNPJ);
        Assert.IsTrue(doc.IsValid);
    }

    public void ShouldReturnErrorWhenCPFIsInvalid()
    {
        var doc = new Document("123", EDocumentType.CPF);
        Assert.IsFalse(doc.IsValid);
    }

    [TestMethod]
    [DataTestMethod]
    [DataRow("56350841093")]
    [DataRow("56350841453")]
    public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
    {
        var doc = new Document(cpf, EDocumentType.CPF);
        Assert.IsTrue(doc.IsValid);
    }
}
