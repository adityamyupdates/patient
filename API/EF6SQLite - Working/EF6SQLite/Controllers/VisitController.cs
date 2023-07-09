using EF6SQLite.BusinessLayer.Interface;
using EF6SQLite.BusinessLayer.Services;
using EF6SQLite.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF6SQLite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitController : ControllerBase
    {
        private readonly IVisitBusinessService _visitBusinessService;

        public VisitController(IVisitBusinessService visitBusinessService)
        {
            _visitBusinessService = visitBusinessService;
        }

        [HttpGet("getallvisit")]
        public List<VisitDetailsContract> GetAllVisit()
        {
            return _visitBusinessService.GetAllVisit();
        }

        [HttpPost("addallvisitdetails")]
        public bool AddallVisitDetails(List<VisitDetailsContract> objVisitDetails)
        {
            return _visitBusinessService.AddallVisitDetails(objVisitDetails);
        }
    }
}
