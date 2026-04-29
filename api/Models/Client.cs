namespace api.Models;

public class Client(string firstName, string lastName, DateOnly dateOfBirth, string phone, string email) : Person(firstName, lastName, dateOfBirth, phone, email)
{

}