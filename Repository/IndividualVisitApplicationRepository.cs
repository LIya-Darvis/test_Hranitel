using HranitelPRO_api.Data;
using HranitelPRO_api.Interfaces;
using HranitelPRO_api.Models;

namespace HranitelPRO_api.Repository;

public class IndividualVisitApplicationRepository : IIndividualVisitApplicationRepository
{
    private readonly DataContext _context;
    
    public IndividualVisitApplicationRepository(DataContext context)
    {
        _context = context;
    }

    public ICollection<IndividualVisitApplication> GetIndividualVisitApplications()
    {
        return _context.IndividualVisitApplications.OrderBy(p => p.Id).ToList();
    }

    public IndividualVisitApplication GetIndividualVisitApplication(int id)
    {
        return _context.IndividualVisitApplications.Where(p => p.Id == id).FirstOrDefault();
    }

    public IndividualVisitApplication GetIndividualVisitApplication(string lastName)
    {
        return _context.IndividualVisitApplications.Where(p => p.LastName == lastName).FirstOrDefault();
    }

    public bool IndividualVisitApplicationExists(int indVisitAppId)
    {
        return _context.IndividualVisitApplications.Any(p => p.Id == indVisitAppId);
    }
}