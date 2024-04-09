using SimpleCrud.Core.Interfaces.Repositories;
using SimpleCrud.Domain.Models;
using SimpleCrud.Infrastructure.Data;

namespace SimpleCrud.Infrastructure.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly SqlContext _context;

        public ProductRepository(SqlContext context) : base(context)
        {
            _context = context;
        }
    }
}
