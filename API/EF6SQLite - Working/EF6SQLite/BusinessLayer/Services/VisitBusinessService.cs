using EF6SQLite.BusinessLayer.Interface;
using EF6SQLite.Contracts;
using EF6SQLite.DataAccessLayer.Interface;
using EF6SQLite.TranslateLayer;

namespace EF6SQLite.BusinessLayer.Services
{
    public class VisitBusinessService : IVisitBusinessService
    {
        private readonly IVisitDBService _visitDBService;
        public VisitBusinessService(IVisitDBService visitDBService)
        {
            _visitDBService = visitDBService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objVisitDetails"></param>
        /// <returns></returns>
        public bool AddallVisitDetails(List<VisitDetailsContract> objVisitDetails)
        {
            try
            {
                VisitTranslation objVisitTranslation = new VisitTranslation();
                var visitModel = objVisitTranslation.ConvertListOfVisitFromContractToModel(objVisitDetails);

                return _visitDBService.AddallVisitDetails(visitModel);
            }
            catch (Exception ex)
            {
                 return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<VisitDetailsContract> GetAllVisit()
        {
            try
            {
                VisitTranslation objVisitTranslation = new VisitTranslation();
                var visitcontract = objVisitTranslation.ConvertListOfVisitFromModelToContract(_visitDBService.GetAllVisit());

                return visitcontract;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
