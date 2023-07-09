using EF6SQLite.BusinessLayer.Interface;
using EF6SQLite.Contracts;
using EF6SQLite.DataAccessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF6SQLite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientBusinessService _patientBusinessService;

        public PatientController(IPatientBusinessService patientBusinessService) 
        {
            _patientBusinessService = patientBusinessService;
        }

        [HttpGet("getpatientdetails")]
        public List<PatientDetailsContract> GetPatientDetails() 
        {
            return _patientBusinessService.GetPatientDetails();
        }

        [HttpGet("getpatientdetailbyid")]
        public PatientDetailsContract GetPatientDetailById(int patientID)
        {
            return _patientBusinessService.GetPatientDetailById(patientID);
        }

        [HttpPost("addpatientdetails")]
        public bool AddPatientDetails(PatientDetailsContract objPatientDetailsContract)
        {
            return _patientBusinessService.AddPatientDetails(objPatientDetailsContract);
        }

        [HttpPut("updatepatientdetails")]
        public bool UpdatePatientDetails(PatientDetailsContract objPatientDetailsContract)
        {
            return _patientBusinessService.UpdatePatientDetails(objPatientDetailsContract);
        }

        [HttpDelete("deletepatientdetails")]
        public bool DeletePatientDetails(int patientID)
        {
            return _patientBusinessService.DeletePatientDetails(patientID);
        }
    }
}
