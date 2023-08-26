using MobileSalesExtraedgeassignment.Model;

namespace MobileSalesExtraedgeassignment.Service
{
    public interface ISalesReportService
    {
        IEnumerable<SalesReport> GetSalesMonthlyReport(DateTime fromDate, DateTime toDate);
    }
}
