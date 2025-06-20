public class GetProductsHandler
{
    private readonly IProductRepository _repository;

    public GetProductsHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<PaginatedResult<Product>> HandleAsync(GetProductsQuery query)
    {
        return await _repository.GetAllAsync(query.Page, query.PageSize);
    }
}