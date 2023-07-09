 using EF6SQLite.BusinessLayer.Interface;
using EF6SQLite.Contracts;
using EF6SQLite.DataAccessLayer.Interface;
using EF6SQLite.TranslateLayer;

namespace EF6SQLite.BusinessLayer.Services
{
    public class PatientBusinessService : IPatientBusinessService
    {
        private readonly IPatientDBService _patientDBService;

        PatientTranslation objPatientTranslation = new PatientTranslation();

        public PatientBusinessService(IPatientDBService patientDBService) 
        {
            _patientDBService = patientDBService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<PatientDetailsContract> GetPatientDetails()
        {
            try
            {
                return objPatientTranslation.ConvertListOfPatientModelToContract(_patientDBService.GetPatientDetails());
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns></returns>
        public PatientDetailsContract GetPatientDetailById(int patientID)
        {
            try
            {
                return objPatientTranslation.ConvertPatientModelToContract(_patientDBService.GetPatientDetailById(patientID));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objPatientDetailsContract"></param>
        /// <returns></returns>
        public bool AddPatientDetails(PatientDetailsContract objPatientDetailsContract)
        {
            try
            {
                var patientModel = objPatientTranslation.ConvertPatientContractToModel(objPatientDetailsContract);
                return _patientDBService.AddPatientDetails(patientModel);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objPatientDetailsContract"></param>
        /// <returns></returns>
        public bool UpdatePatientDetails(PatientDetailsContract objPatientDetailsContract)
        {
            try
            {
                return _patientDBService.UpdatePatientDetails(objPatientDetailsContract);
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool DeletePatientDetails(int patientID)
        {
            try
            {
                return _patientDBService.DeletePatientDetails(patientID);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
