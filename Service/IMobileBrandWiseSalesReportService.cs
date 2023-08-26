using MobileSalesExtraedgeassignment.Model;

namespace MobileSalesExtraedgeassignment.Service
{
    public interface IMobileBrandWiseSalesReportService
    {
        IEnumerable<BrandWiseMobile> MobilebrandWiseSalesReport(DateTime fromDate, DateTime toDate);
    }
}
