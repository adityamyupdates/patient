using EF6SQLite.Contracts;

namespace EF6SQLite.BusinessLayer.Interface
{
    public interface IVisitBusinessService
    {
        bool AddallVisitDetails(List<VisitDetailsContract> objVisitDetails);
        List<VisitDetailsContract> GetAllVisit();

    }
}
