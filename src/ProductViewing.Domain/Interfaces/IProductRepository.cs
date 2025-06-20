public interface IProductRepository
{
    Task<PaginatedResult<Product>> GetAllAsync(int page, int pageSize);
}