namespace EF6SQLite.DataAccessLayer.Interface
{
    public interface IVisitDBService
    {
        bool AddallVisitDetails(List<VisitDetails> objVisitDetails);
        List<VisitDetails> GetAllVisit();
    }
}
