using EF6SQLite.Contracts;
using EF6SQLite.DataAccessLayer.Interface;

namespace EF6SQLite.DataAccessLayer.Services
{
    public class PatientDBService : IPatientDBService
    {
        private readonly DataContext _dataContext;
        public PatientDBService(DataContext dataContext) 
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// This function will fetch all the patient record 
        /// </summary>
        /// <returns></returns>
        public List<PatientDetails> GetPatientDetails()
        {
            try
            {
                return _dataContext.PatientDetails.Where(x => x.IsDeleted == false).ToList();
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
        public PatientDetails GetPatientDetailById(int patientID)
        {
            try
            {
                return _dataContext.PatientDetails.Where(x => x.PatientID == patientID && x.IsDeleted == false).Single();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objPatientDetails"></param>
        /// <returns></returns>
        public bool AddPatientDetails(PatientDetails objPatientDetails)
        {
            bool isAdded = false;
            try
            {
                _dataContext.PatientDetails.Add(objPatientDetails);
                _dataContext.SaveChanges();
                isAdded = true;
            }
            catch (Exception ex)
            {
                return isAdded;
            }
            return isAdded;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objPatientDetails"></param>
        /// <returns></returns>
        public bool UpdatePatientDetails(PatientDetailsContract objPatientDetailsContract)
        {
            bool isUpdated = false;
            try
            {
                if (objPatientDetailsContract.PatientID != 0)
                {
                    var result = _dataContext.PatientDetails.Where(_x => _x.PatientID == objPatientDetailsContract.PatientID).Single();

                    result.FirstName = objPatientDetailsContract.FirstName == "" ? result.FirstName: objPatientDetailsContract.FirstName;
                    result.LastName = objPatientDetailsContract.LastName == "" ? result.LastName : objPatientDetailsContract.LastName;
                    result.Address = objPatientDetailsContract.Address == "" ? result.Address : objPatientDetailsContract.Address;
                    result.State = objPatientDetailsContract.State == "" ? result.State : objPatientDetailsContract.State;
                    result.City = objPatientDetailsContract.City == "" ? result.City : objPatientDetailsContract.City;
                    result.OrganizationId = objPatientDetailsContract.OrganizationId == 0 ? result.OrganizationId : objPatientDetailsContract.OrganizationId; 
                    result.UpdatedAt = DateTime.Now;
                    result.IsDeleted = objPatientDetailsContract.IsDeleted;

                    _dataContext.SaveChanges();
                    isUpdated = true;
                }
                else
                {
                    isUpdated = false;
                }
                
            }
            catch (Exception ex)
            {
                return isUpdated;
            }
            return isUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns></returns>
        public bool DeletePatientDetails(int patientID)
        {
            bool isDeleted = false;
            try
            {
                if (patientID != 0)
                {
                    var result = _dataContext.PatientDetails.Where(_x => _x.PatientID == patientID).Single();

                    result.IsDeleted = true;

                    _dataContext.SaveChanges();
                    isDeleted = true;
                }
                else
                {
                    isDeleted = false;
                }

            }
            catch (Exception ex)
            {
                return isDeleted;
            }
            return isDeleted;
        }

    }
}
