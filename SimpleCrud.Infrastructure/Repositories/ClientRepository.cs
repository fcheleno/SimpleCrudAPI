using SimpleCrud.Core.Interfaces.Repositories;
using SimpleCrud.Domain.Models;
using SimpleCrud.Infrastructure.Data;

namespace SimpleCrud.Infrastructure.Repositories
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        private readonly SqlContext _context;

        public ClientRepository(SqlContext context) : base(context)
        {
            _context = context;
        }
    }
}
