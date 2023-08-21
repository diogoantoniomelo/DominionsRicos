using Flunt.Validations;

public class Name : ValueObject
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        if (string.IsNullOrEmpty(FirstName))
            AddNotifications(
                new Contract<Name>()
                    .Requires()
                    .IsLowerThan(
                        FirstName,
                        3,
                        "Name.FistName",
                        "O nome deve conter mais de 3 caracteres"
                    )
                    .IsLowerThan(
                        LastName,
                        3,
                        "Name.LastName",
                        "O nome deve conter mais de 3 caracteres"
                    )
            );
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
}
