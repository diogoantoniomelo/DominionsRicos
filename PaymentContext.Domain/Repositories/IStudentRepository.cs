using PaymentContext.Domain.Entities;

public interface IStudentRepository
{
    bool DocumentExists(string document);
    bool EmailExists(string email);
    void CreateSubscription(Student student);
}
