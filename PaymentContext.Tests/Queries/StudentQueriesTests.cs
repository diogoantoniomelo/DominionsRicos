using PaymentContext.Domain.Entities;

[TestClass]
public class StudentQueriesTests
{
    // Red, Green, Refactor
    private IList<Student> _students;

    public StudentQueriesTests()
    {
        _students = new List<Student>();
        for (var i = 0; i <= 10; i++)
        {
            _students.Add(
                new Student(
                    new Name("Aluno", i.ToString()),
                    new Document("1111111111" + i.ToString(), EDocumentType.CPF),
                    new Email(i.ToString() + "@spfc.com")
                )
            );
        }
    }

    [TestMethod]
    public void ShouldReturnsStudentWhenDocumentNotExists()
    {
        var exp = StudentQueries.GetStudentInfo("12345678901");
        var student = _students.AsQueryable().Where(exp).FirstOrDefault();

        Assert.AreEqual(null, student);
    }

    [TestMethod]
    public void ShouldReturnsStudentWhenDocumentExists()
    {
        var exp = StudentQueries.GetStudentInfo("11111111111");
        var student = _students.AsQueryable().Where(exp).FirstOrDefault();

        Assert.AreEqual(null, student);
    }
}
