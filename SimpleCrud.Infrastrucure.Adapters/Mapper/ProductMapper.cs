using SimpleCrud.Domain.Dtos;
using SimpleCrud.Domain.Models;
using SimpleCrud.Infrastructure.Adapters.Mapper.Interfaces;

namespace SimpleCrud.Infrastructure.Adapters.Mapper
{
    public class ProductMapper : IProductMapper
    {
        List<ProductDto> productListDto = new List<ProductDto>();

        public Product MapperToEntity(ProductDto ProductDto)
        {
            var product = new Product
            {
                Id = ProductDto.Id,
                Name = ProductDto.Name,
                Value = ProductDto.Value,
                ClientId = ProductDto.ClientId,
            };

            return product;
        }

        public IEnumerable<ProductDto> MapperProductList(IEnumerable<Product> products)
        {
            foreach (var p in products)
            {
                var productDto = new ProductDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Value = p.Value,
                    ClientId = p.ClientId,
                };

                productListDto.Add(productDto);
            }

            return productListDto;
        }

        public ProductDto MapperToDto(Product product)
        {
            var productDto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Value = product.Value,
                ClientId = product.ClientId,
            };

            return productDto;
        }
    }
}
