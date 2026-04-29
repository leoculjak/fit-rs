namespace api.Models;

public class Technician(string firstName, string lastName, DateOnly dateOfBirth, string phone, string email, string department)
 : Person(firstName, lastName, dateOfBirth, phone, email)
{
    public required string Department { get; set; } = department;

}
