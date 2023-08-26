using PaymentContext.Domain.Entities;

public class FakeEmailService : IEmailService
{
    public void Send(string to, string email, string subject, string body) { }
}
