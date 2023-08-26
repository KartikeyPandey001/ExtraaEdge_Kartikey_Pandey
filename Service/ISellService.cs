using MobileSalesExtraedgeassignment.Model;

namespace MobileSalesExtraedgeassignment.Service
{
    public interface ISellService
    {
        IEnumerable<Sell> GetAllSell();
        Sell GetSellById(int id);
        int AddSell(Sell sell);
        int UpdateSell(Sell sell);
        int DeleteSell(int id);
    }
}
