using Catalog.Business.IServices;
using Catalog.Data.Context;
using Catalog.Entities;
using Moq;

namespace Catalog.Business.Tests.Services
{
    public class ProductServiceTests
    {
        private Mock<ICatalogContext> _catalogContext;
        public ProductServiceTests()
        {
            _catalogContext = new Mock<ICatalogContext>();
        }

        [Fact]
        public async void GetProducts_ReturnAllProducts()
        {
            //Arrange 
            var products = new List<Product>() { 
                new Product
                {
                    Id = "11111111",
                    Category = "Category One",
                    Name = "Name here",
                    Price = 200,
                    Description = "Description here",
                    Summary = "Summery Here",
                    ImageFile = "default.png"
                }
            };
            Mock<IProductService> _productService = new Mock<IProductService>();
            _productService.Setup(x => x.GetProducts()).ReturnsAsync(products.AsEnumerable());

            var result = await _productService.Object.GetProducts();

            Assert.Equal(products, result);

        }
    }
}
