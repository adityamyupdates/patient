using EF6SQLite.Contracts;

namespace EF6SQLite.DataAccessLayer.Interface
{
    public interface IPatientDBService
    {
        List<PatientDetails> GetPatientDetails();
        PatientDetails GetPatientDetailById(int patientID);
        bool AddPatientDetails(PatientDetails objPatientDetails);
        bool UpdatePatientDetails(PatientDetailsContract objPatientDetailsContract);
        bool DeletePatientDetails(int patientID);
    }
}
