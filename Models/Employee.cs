namespace HranitelPRO_api.Models;

public class Employee
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public Subdivision Subdivision { get; set; }
    public Department Deparment { get; set; }
    public int Code { get; set; }
}