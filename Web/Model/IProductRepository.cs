using Store;

namespace Site
{
    public interface IProductRepository
    {
        Product[] GetByName(string namePart);
        Product[] GetByCategory(string categoryName);
        Product[] GetByManufacturer(string manufacturer);
    }
}
