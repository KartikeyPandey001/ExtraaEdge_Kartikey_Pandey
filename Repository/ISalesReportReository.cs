using MobileSalesExtraedgeassignment.Model;

namespace MobileSalesExtraedgeassignment.Repository
{
    public interface ISalesReportReository
    {
        IEnumerable<SalesReport> GetSalesMonthlyReport(DateTime fromDate, DateTime toDate);
    }
}
