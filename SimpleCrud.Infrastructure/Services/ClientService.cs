using SimpleCrud.Core.Interfaces.Repositories;
using SimpleCrud.Core.Interfaces.Services;
using SimpleCrud.Domain.Models;

namespace SimpleCrud.Infrastructure.Services
{
    public class ClientService : BaseService<Client>, IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository ClientRepository) : base(ClientRepository)
        {
            _clientRepository = ClientRepository;
        }
    }
}
