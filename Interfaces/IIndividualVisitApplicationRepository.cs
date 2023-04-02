using HranitelPRO_api.Models;

namespace HranitelPRO_api.Interfaces;

public interface IIndividualVisitApplicationRepository
{
    ICollection<IndividualVisitApplication> GetIndividualVisitApplications();

    IndividualVisitApplication GetIndividualVisitApplication(int id);
    IndividualVisitApplication GetIndividualVisitApplication(string lastName);
    bool IndividualVisitApplicationExists(int indVisitAppId);
}