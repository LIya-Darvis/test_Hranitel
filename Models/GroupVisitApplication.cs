namespace HranitelPRO_api.Models;

public class GroupVisitApplication
{
    public int Id { get; set; }
    public User User { get; set; }
    public DateTime PassStart { get; set; }
    public DateTime PassEnd { get; set; }
    public PassGoal PassGoal { get; set; }
    public Subdivision Subdivision { get; set; }
    public Employee Employee { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Organisation { get; set; }
    public string Note { get; set; }
    public DateTime Birthday { get; set; }
    public int PassportSeries { get; set; }
    public int PassportNumber { get; set; }
    public string Photo { get; set; }
    public string PassportScan { get; set; }
    public bool IsApproved { get; set; }
    public string Comment { get; set; }
}