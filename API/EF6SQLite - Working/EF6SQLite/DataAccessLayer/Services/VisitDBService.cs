using EF6SQLite.DataAccessLayer.Interface;

namespace EF6SQLite.DataAccessLayer.Services
{
    public class VisitDBService : IVisitDBService
    {
        private readonly DataContext _dataContext;
        public VisitDBService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objVisitDetails"></param>
        /// <returns></returns>
        public bool AddallVisitDetails(List<VisitDetails> objVisitDetails)
        {
            bool isAdded = false;
            try
            {
                foreach (var visitDetails in objVisitDetails)
                {
                    _dataContext.VisitDetails.Add(visitDetails);
                }
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
        /// <returns></returns>
        public List<VisitDetails> GetAllVisit()
        {
            try
            {
                return _dataContext.VisitDetails.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
