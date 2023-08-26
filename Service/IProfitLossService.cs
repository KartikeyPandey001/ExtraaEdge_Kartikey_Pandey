using MobileSalesExtraedgeassignment.Model;

namespace MobileSalesExtraedgeassignment.Service
{
    public interface IProfitLossService
    {
        IEnumerable<ProfitLoss> GetProfitLossReport(DateTime fromDate, DateTime toDate);
    }
}
