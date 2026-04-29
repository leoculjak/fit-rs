namespace api.Models;

public class Doctor(string firstName, string lastName, DateOnly dateOfBirth, string phone, string email, string licenseNumber, string specialization)
: Person(firstName, lastName, dateOfBirth, phone, email)
{
    public required string LicenseNumber { get; set; } = licenseNumber;
    public required string Specialization { get; set; } = specialization;
}