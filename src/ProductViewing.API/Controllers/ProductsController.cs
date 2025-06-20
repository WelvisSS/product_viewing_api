using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly GetProductsHandler _handler;

    public ProductsController(GetProductsHandler handler)
    {
        _handler = handler;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
    {
        var result = await _handler.HandleAsync(new GetProductsQuery { Page = page, PageSize = pageSize });
        return Ok(result);
    }
}