using SimpleCrud.Domain.Dtos;
using SimpleCrud.Domain.Models;
using SimpleCrud.Infrastructure.Adapters.Mapper.Interfaces;

namespace SimpleCrud.Infrastructure.Adapters.Mapper
{
    public class ProductMapper : IProductMapper
    {
        List<ProductDto> productListDto = new List<ProductDto>();
        List<ProductViewDto> productViewListDto = new List<ProductViewDto>();

        public Product MapperToEntity(ProductDto productDto)
        {
            var product = new Product
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Value = productDto.Value,
                ClientId = productDto.ClientId,
            };

            return product;
        }

        public Product MapperToEntity(ProductCreateDto productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                Value = productDto.Value,
                ClientId = productDto.ClientId,
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

        public IEnumerable<ProductViewDto> MapperProductViewList(IEnumerable<Product> products)
        {
            foreach (var p in products)
            {
                var productViewDto = new ProductViewDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Value = p.Value,
                    ClientId = p.ClientId,
                    CreateDate = p.CreateDate,
                    UpdateDate = p.UpdateDate,
                };

                productViewListDto.Add(productViewDto);
            }

            return productViewListDto;
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

        public ProductViewDto MapperToViewDto(Product product)
        {
            var productViewDto = new ProductViewDto
            {
                Id = product.Id,
                Name = product.Name,
                Value = product.Value,
                ClientId = product.ClientId,
                CreateDate = product.CreateDate,
                UpdateDate = product.UpdateDate,
            };

            return productViewDto;
        }
    }
}
