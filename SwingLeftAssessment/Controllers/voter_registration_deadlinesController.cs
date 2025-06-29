using Microsoft.AspNetCore.Mvc;
using SwingLeftAssessment.Models;
using SwingLeftAssessment.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwingLeftAssessment.Controllers
{
  [Produces("application/json")]
  [Route("apideadlines")]
  [ApiController]
  public class voter_registration_deadlinesController : ControllerBase
  {
    private readonly Ivoter_registration_deadlines_service _Registration_Deadlines_Service;
    public voter_registration_deadlinesController(Ivoter_registration_deadlines_service registration_Deadlines_Service)
    {
      _Registration_Deadlines_Service = registration_Deadlines_Service;
    }

    // GET: api/<voter_registration_deadlinesController>
    [HttpGet]
    public IEnumerable<voter_registration_deadlines> Get()
    {
      return _Registration_Deadlines_Service.ReadAll();
    }
  }
}
