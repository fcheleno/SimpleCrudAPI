using SimpleCrud.Application.Service.Interfaces;
using SimpleCrud.Core.Interfaces.Services;
using SimpleCrud.Domain.Dtos;
using SimpleCrud.Infrastructure.Adapters.Mapper.Interfaces;

namespace SimpleCrud.Application.Service
{
    public class ApplicationProductService : IDisposable, IApplicationProductService
    {
        private readonly IProductService _productService;
        private readonly IProductMapper _productMapper;

        public ApplicationProductService(IProductService productService, IProductMapper productMapper)
        {
            _productService = productService;
            _productMapper = productMapper;
        }       

        public ProductDto GetById(int id)
        {
            var product = _productService.GetById(id);
            return _productMapper.MapperToDto(product);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var products = _productService.GetAll();
            return _productMapper.MapperProductList(products);
        }

        public void Add(ProductDto productDto)
        {
            var produto = _productMapper.MapperToEntity(productDto);
            _productService.Add(produto);
        }

        public void Update(ProductDto productDto)
        {
            var product = _productMapper.MapperToEntity(productDto);
            _productService.Update(product);
        }

        public void Remove(ProductDto productDto)
        {
            var product = _productMapper.MapperToEntity(productDto);
            _productService.Remove(product);
        }

        public void Dispose()
        {
            _productService.Dispose();
        }
    }
}
