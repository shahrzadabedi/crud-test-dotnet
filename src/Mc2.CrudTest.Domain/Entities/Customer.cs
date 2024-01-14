namespace Mc2.CrudTest.Domain.Entities;

public class Customer
{
    public Guid Id { get; set; }

    public string FirstName { private set; get; }

    public string LastName { private set; get; }

    public DateTime DateOfBirth { private set; get; }

    public string PhoneNumber { private set; get; }

    public string Email { private set; get; }

    public string BankAccountNumber { private set; get; }
}
