using SimpleCrud.Domain.Dtos;

namespace SimpleCrud.Application.Service.Interfaces
{
    public interface IApplicationProductService
    {
        ProductDto GetById(int id);

        IEnumerable<ProductDto> GetAll();

        void Add(ProductDto obj);

        void Update(ProductDto obj);

        void Remove(ProductDto obj);

        void Dispose();
    }
}
