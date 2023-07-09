using EF6SQLite.Contracts;

namespace EF6SQLite.TranslateLayer
{
    public class PatientTranslation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objAllPatientDetail"></param>
        /// <returns></returns>
        public List<PatientDetailsContract> ConvertListOfPatientModelToContract(List<PatientDetails> objAllPatientDetail)
        {
            List<PatientDetailsContract> objpatientDetailsContractList = new List<PatientDetailsContract>();
            try
			{
				foreach (var patientDetail in objAllPatientDetail)
				{
                    PatientDetailsContract objpatientDetailsContract = new PatientDetailsContract();

                    objpatientDetailsContract.PatientID = patientDetail.PatientID;
                    objpatientDetailsContract.FirstName = patientDetail.FirstName;
                    objpatientDetailsContract.LastName = patientDetail.LastName;
                    objpatientDetailsContract.Address = patientDetail.Address;
                    objpatientDetailsContract.State = patientDetail.State;
                    objpatientDetailsContract.City = patientDetail.City;
                    objpatientDetailsContract.OrganizationId = patientDetail.OrganizationId;
                    objpatientDetailsContract.CreatedAt = patientDetail.CreatedAt;
                    objpatientDetailsContract.UpdatedAt = patientDetail.UpdatedAt;
                    objpatientDetailsContract.IsDeleted = patientDetail.IsDeleted;

                    objpatientDetailsContractList.Add(objpatientDetailsContract);
                }
			}
			catch (Exception ex)
			{

			}
            return objpatientDetailsContractList;
        }

        public PatientDetailsContract ConvertPatientModelToContract(PatientDetails objPatientDetail)
        {
            PatientDetailsContract objpatientDetailsContract = new PatientDetailsContract();
            try
            {
                if (objPatientDetail != null)
                {
                    objpatientDetailsContract.PatientID = objPatientDetail.PatientID;
                    objpatientDetailsContract.FirstName = objPatientDetail.FirstName;
                    objpatientDetailsContract.LastName = objPatientDetail.LastName;
                    objpatientDetailsContract.Address = objPatientDetail.Address;
                    objpatientDetailsContract.State = objPatientDetail.State;
                    objpatientDetailsContract.City = objPatientDetail.City;
                    objpatientDetailsContract.OrganizationId = objPatientDetail.OrganizationId;
                    objpatientDetailsContract.CreatedAt = objPatientDetail.CreatedAt;
                    objpatientDetailsContract.UpdatedAt = objPatientDetail.UpdatedAt;
                    objpatientDetailsContract.IsDeleted = objPatientDetail.IsDeleted;
                }
                
            }
            catch (Exception ex)
            {
                return null;
            }
            return objpatientDetailsContract;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objPatientDetailsContract"></param>
        /// <returns></returns>
        public PatientDetails ConvertPatientContractToModel(PatientDetailsContract objPatientDetailsContract)
        {
            PatientDetails objPatientDetails = new PatientDetails();
            try
            {
                if (objPatientDetailsContract != null)
                {
                    objPatientDetails.FirstName = objPatientDetailsContract.FirstName;
                    objPatientDetails.LastName = objPatientDetailsContract.LastName;
                    objPatientDetails.Address = objPatientDetailsContract.Address;
                    objPatientDetails.State = objPatientDetailsContract.State;
                    objPatientDetails.City = objPatientDetailsContract.City;
                    objPatientDetails.OrganizationId = objPatientDetailsContract.OrganizationId;
                    objPatientDetails.CreatedAt = DateTime.Now;
                    objPatientDetails.UpdatedAt = DateTime.Now;
                    objPatientDetails.IsDeleted = objPatientDetailsContract.IsDeleted;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            return objPatientDetails;
        }

    }
}
