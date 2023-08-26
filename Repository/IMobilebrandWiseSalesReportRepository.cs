using MobileSalesExtraedgeassignment.Model;

namespace MobileSalesExtraedgeassignment.Repository
{
    public interface IMobilebrandWiseSalesReportRepository
    {
        IEnumerable<BrandWiseMobile> MobilebrandWiseSalesReport(DateTime fromDate, DateTime toDate);
    }
}
