using System.Linq.Expressions;
using PaymentContext.Domain.Entities;

public static class StudentQueries
{
    public static Expression<Func<Student, bool>> GetStudentInfo(string document)
    {
        return x => x.Document.Number == document;
    }
}
