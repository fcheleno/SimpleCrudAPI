using SimpleCrud.Domain.Dtos;

namespace SimpleCrud.Application.Service.Interfaces
{
    public interface IApplicationProductService
    {
        ProductViewDto GetById(int id);

        IEnumerable<ProductViewDto> GetAll();

        void Add(ProductCreateDto obj);

        void Update(ProductDto obj);

        void Remove(ProductDto obj);

        void Dispose();
    }
}
