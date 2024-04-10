using SimpleCrud.Core.Interfaces.Repositories;
using SimpleCrud.Core.Interfaces.Services;
using SimpleCrud.Domain.Models;

namespace SimpleCrud.Infrastructure.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
