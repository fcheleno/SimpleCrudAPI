using SimpleCrud.Domain.Dtos;
using SimpleCrud.Domain.Models;

namespace SimpleCrud.Infrastructure.Adapters.Mapper.Interfaces
{
    public interface IProductMapper
    {
        Product MapperToEntity(ProductDto productDto);

        IEnumerable<ProductDto> MapperProductList(IEnumerable<Product> products);

        ProductDto MapperToDto(Product product);
    }
}
