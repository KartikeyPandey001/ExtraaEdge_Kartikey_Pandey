using MobileSalesExtraedgeassignment.Model;

namespace MobileSalesExtraedgeassignment.Repository
{
    public interface IProfitLossRepository
    {
        IEnumerable<ProfitLoss> GetProfitLossReport(DateTime fromDate, DateTime toDate);
    }
}
