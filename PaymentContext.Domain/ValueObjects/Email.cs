using Flunt.Validations;

public class Email : ValueObject
{
    public Email(string address)
    {
        Address = address;
        AddNotifications(
            new Contract<Email>().Requires().IsEmail(Address, "Email.Adress", "E-mail inválido")
        );
    }

    public string Address { get; private set; }
}
