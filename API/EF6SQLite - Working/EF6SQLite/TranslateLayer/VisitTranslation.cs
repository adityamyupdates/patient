using EF6SQLite.Contracts;

namespace EF6SQLite.TranslateLayer
{
    public class VisitTranslation
    {
        /// <summary>
        /// This will 
        /// </summary>
        /// <param name="objVisitDetailsContract"></param>
        /// <returns></returns>
        public List<VisitDetails> ConvertListOfVisitFromContractToModel(List<VisitDetailsContract> objVisitDetailsContract)
        {
            List<VisitDetails> objVisitDetailsList = new List<VisitDetails>();
            try
            {
                foreach (var visitDetailsContract in objVisitDetailsContract)
                {
                    VisitDetails objVisitDetails = new VisitDetails();

                    objVisitDetails.VisitId = visitDetailsContract.VisitId;
                    objVisitDetails.PatientId = visitDetailsContract.PatientId;
                    objVisitDetails.VisitDate = DateTime.Now;
                    objVisitDetails.ProgressNotes = visitDetailsContract.ProgressNotes;
                    objVisitDetails.SectionName = visitDetailsContract.SectionName;
                    objVisitDetails.Height = visitDetailsContract.Height;
                    objVisitDetails.Weight = visitDetailsContract.Weight;
                    objVisitDetails.Temperature = visitDetailsContract.Temperature;
                     
                    objVisitDetailsList.Add(objVisitDetails);
                }
            }
            catch (Exception ex)
            {

            }
            return objVisitDetailsList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objVisitDetailsContract"></param>
        /// <returns></returns>
        public List<VisitDetailsContract> ConvertListOfVisitFromModelToContract(List<VisitDetails> objVisitDetails)
        {
            List<VisitDetailsContract> objVisitDetailsContractList = new List<VisitDetailsContract>();
            try
            {
                foreach (var visitDetails in objVisitDetails)
                {
                    VisitDetailsContract objVisitDetailsContract = new VisitDetailsContract();

                    objVisitDetailsContract.VisitId = visitDetails.VisitId;
                    objVisitDetailsContract.PatientId = visitDetails.PatientId;
                    objVisitDetailsContract.VisitDate = visitDetails.VisitDate;
                    objVisitDetailsContract.ProgressNotes = visitDetails.ProgressNotes;
                    objVisitDetailsContract.SectionName = visitDetails.SectionName;
                    objVisitDetailsContract.Height = visitDetails.Height;
                    objVisitDetailsContract.Weight = visitDetails.Weight;
                    objVisitDetailsContract.Temperature = visitDetails.Temperature;

                    objVisitDetailsContractList.Add(objVisitDetailsContract);
                }
            }
            catch (Exception ex)
            {

            }
            return objVisitDetailsContractList;
        }
    }
}
