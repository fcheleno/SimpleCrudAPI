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

        public ProductViewDto GetById(int id)
        {
            var product = _productService.GetById(id);
            return _productMapper.MapperToViewDto(product);
        }

        public IEnumerable<ProductViewDto> GetAll()
        {
            var products = _productService.GetAll();
            return _productMapper.MapperProductViewList(products);
        }

        public void Add(ProductCreateDto productDto)
        {
            var product = _productMapper.MapperToEntity(productDto);
            product.CreateDate = DateTime.Now;
            _productService.Add(product);
        }

        public void Update(ProductDto productDto)
        {
            var product = _productMapper.MapperToEntity(productDto);
            product.UpdateDate = DateTime.Now;
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
