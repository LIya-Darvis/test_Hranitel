using HranitelPRO_api.Interfaces;
using HranitelPRO_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace HranitelPRO_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IndividualVisitApplicationController : Controller
{
    private readonly IIndividualVisitApplicationRepository _individualVisitApplicationRepository;

    public IndividualVisitApplicationController(IIndividualVisitApplicationRepository individualVisitApplicationRepository)
    {
        _individualVisitApplicationRepository = individualVisitApplicationRepository;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<IndividualVisitApplication>))]
    public IActionResult GetIndividualVisitApplications()
    {
        var individualVisitApplications = _individualVisitApplicationRepository.GetIndividualVisitApplications();

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(individualVisitApplications);
    }

    [HttpGet("{indVisitAppId}")]
    [ProducesResponseType(200, Type = typeof(IndividualVisitApplication))]
    [ProducesResponseType(400)]
    public IActionResult GetIndividualVisitApplication(int indVisitAppId)
    {
        if (!_individualVisitApplicationRepository.IndividualVisitApplicationExists(indVisitAppId))
        {
            return NotFound();
        }

        var individualVisitApplication =
            _individualVisitApplicationRepository.GetIndividualVisitApplication(indVisitAppId);

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(individualVisitApplication);
    }
    
    
    
}