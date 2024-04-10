using SimpleCrud.Domain.Dtos;
using SimpleCrud.Domain.Models;

namespace SimpleCrud.Infrastructure.Adapters.Mapper.Interfaces
{
    public interface IProductMapper
    {
        Product MapperToEntity(ProductDto productDto);

        Product MapperToEntity(ProductCreateDto productDto);

        IEnumerable<ProductDto> MapperProductList(IEnumerable<Product> products);

        IEnumerable<ProductViewDto> MapperProductViewList(IEnumerable<Product> products);

        ProductDto MapperToDto(Product product);
        
        ProductViewDto MapperToViewDto(Product product);
    }
}
