using EF6SQLite.Contracts;

namespace EF6SQLite.BusinessLayer.Interface
{
    public interface IPatientBusinessService
    {
        List<PatientDetailsContract> GetPatientDetails();
        PatientDetailsContract GetPatientDetailById(int patientID);
        bool AddPatientDetails(PatientDetailsContract objPatientDetailsContract);
        bool UpdatePatientDetails(PatientDetailsContract objPatientDetailsContract);
        bool DeletePatientDetails(int patientID);
    }
}
