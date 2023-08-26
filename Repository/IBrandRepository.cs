using MobileSalesExtraedgeassignment.Model;

namespace MobileSalesExtraedgeassignment.Repository
{
    public interface IBrandRepository
    {
        IEnumerable<Brand> GetAllBrand();
        Brand GetBrandById(int id);
        int AddBrand(Brand brand);
        
        int UpdateBrand(Brand brand);
        int DeleteBrand(int id);
    }
}
