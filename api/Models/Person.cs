namespace api.Models;

public abstract class Person
{
    protected Person(string firstName, string lastName, DateOnly dateOfBirth, string phone, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Phone = phone;
        Email = email;
    }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}
