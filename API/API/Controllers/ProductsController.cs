using store.Service.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using store.Service.ProductsService;

namespace store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productsService;
        private readonly ILogger<IProductService> _logger;

        public ProductsController(ILogger<IProductService> logger,
                                  IProductService productService)
        {
            _productsService = productService;
            _logger = logger;
        }


        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(List<Products>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [HttpGet(Name = "getProducts")]
        public async Task<ActionResult<List<Products>>> GetProducts()
        {
            var products = await _productsService.GetProductsAsync();
            if (!products.Any())
            {
                return NotFound();
            }
            return Ok(products);
        }

        [SwaggerResponse(StatusCodes.Status201Created)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [HttpPost(Name = "createProduct")]
        public async Task<IActionResult> CreateProduct([FromBody] ProductForCreation product)
        {
            var createdProduct = await _productsService.CreateNewProduct(product);


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(createdProduct);
        }

        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(Products))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [HttpGet("{id}", Name = "GetResultWithProductId")]
        public async Task<ActionResult<Products>> GetResultWithProductId(int id)
        {
            var product = await _productsService.GetProductById(id);
            if (product is null)
                return NotFound();
            return Ok(product);
        }


        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(Products))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [HttpPut("{id}", Name = "UpdateProduct")]
        public async Task<ActionResult<Products>> UpdateProduct([FromBody] ProductForUpdating product, int id)
        {
            var updatedProduct = await _productsService.UpdateProducts(product, id);
            if (updatedProduct is null)
            {
                return NotFound();
            }
            return Ok(updatedProduct);
        }


        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(List<Products>))]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [HttpGet("category/{category}", Name = "getProductsByCategory")]
        public async Task<ActionResult<List<Products>>> GetLaptopsOnly(string category)
        {
            var products = await _productsService.FindProductsByCategory(category);

            if (products is null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status404NotFound)]
        [HttpPatch("{id}",Name = "increasingTheSearchedProduct")]
        public async Task<IActionResult> increasingTheSearchedProduct(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            await _productsService.IncreasingTheSearchedProduct(id);

            return Ok();
        }
    }
}
