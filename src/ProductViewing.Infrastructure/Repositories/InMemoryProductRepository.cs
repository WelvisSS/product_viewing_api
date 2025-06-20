public class InMemoryProductRepository : IProductRepository
{
    private static readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Camisa Regular Básica", Price = 210.90m, ImageUrl = "https://img.lojasrenner.com.br/item/834665201/large/12.jpg" },
        new Product { Id = 2, Name = "Camisa Comfort em Linho", Price = 389.50m, ImageUrl = "https://img.lojasrenner.com.br/item/574165082/original/12.jpg" },
        new Product { Id = 3, Name = "Camisa Polo Slim com Botões", Price = 250.00m, ImageUrl = "https://img.lojasrenner.com.br/item/927344600/original/12.jpg" },
        new Product { Id = 4, Name = "Camiseta Relaxed em Algodão", Price = 320.75m, ImageUrl = "https://img.lojasrenner.com.br/item/922248441/original/12.jpg" },
        new Product { Id = 5, Name = "Camisa Polo em Tricô Buclé", Price = 275.30m, ImageUrl = "https://img.lojasrenner.com.br/item/928178674/original/12.jpg" },
        new Product { Id = 6, Name = "Camisa Polo Boxy", Price = 399.90m, ImageUrl = "https://img.lojasrenner.com.br/item/928133290/original/12.jpg" },
        new Product { Id = 7, Name = "Regata Esportiva em Degrade", Price = 215.00m, ImageUrl = "https://img.lojasrenner.com.br/item/894671911/original/12.jpg" },
        new Product { Id = 8, Name = "Camisa Comfort em Flanela", Price = 365.40m, ImageUrl = "https://img.lojasrenner.com.br/item/928496648/original/12.jpg" },
        new Product { Id = 9, Name = "Camisa em Algodão Xadrez", Price = 299.99m, ImageUrl = "https://img.lojasrenner.com.br/item/927855047/original/12.jpg" },
        new Product { Id = 10, Name = "Suéter Básico em Tricô", Price = 220.00m, ImageUrl = "https://img.lojasrenner.com.br/item/927676778/original/13.jpg" },
        new Product { Id = 11, Name = "Suéter Básico em Tricô", Price = 340.00m, ImageUrl = "https://img.lojasrenner.com.br/item/927676997/original/12.jpg" },
        new Product { Id = 12, Name = "Camiseta Esportiva com Tecnologia Dry", Price = 380.00m, ImageUrl = "https://img.lojasrenner.com.br/item/927735723/original/12.jpg" },
        new Product { Id = 13, Name = "Camiseta Esportiva em Tecnologia Dry", Price = 205.00m, ImageUrl = "https://img.lojasrenner.com.br/item/916266511/original/12.jpg" },
        new Product { Id = 14, Name = "Regata Regular Esportiva", Price = 270.00m, ImageUrl = "https://img.lojasrenner.com.br/item/927590843/original/12.jpg" },
        new Product { Id = 15, Name = "Camiseta Slim Maquinetada", Price = 390.00m, ImageUrl = "https://img.lojasrenner.com.br/item/927817981/original/12.jpg" },

    };

    public Task<PaginatedResult<Product>> GetAllAsync(int page, int pageSize)
    {
        var items = _products
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        return Task.FromResult(new PaginatedResult<Product>
        {
            Items = items,
            Page = page,
            PageSize = pageSize,
            TotalCount = _products.Count
        });
    }
}