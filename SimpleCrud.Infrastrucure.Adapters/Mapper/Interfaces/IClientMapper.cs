using SimpleCrud.Domain.Dtos;
using SimpleCrud.Domain.Models;

namespace SimpleCrud.Infrastructure.Adapters.Mapper.Interfaces
{
    public interface IClientMapper
    {
        Client MapperToEntity(ClientDto clientDto);

        IEnumerable<ClientDto> MapperClientList(IEnumerable<Client> clients);

        ClientDto MapperToDto(Client client);
    }
}
