namespace HranitelPRO_api.Models;

public class GroupVisit
{
    public int Id { get; set; }
    public string Purpose { get; set; }
    public Group Group { get; set; }
    public GroupVisitApplication GroupVisitApplication { get; set; }
}