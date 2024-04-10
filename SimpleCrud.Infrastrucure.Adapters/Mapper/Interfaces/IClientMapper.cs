using SimpleCrud.Domain.Dtos;
using SimpleCrud.Domain.Models;

namespace SimpleCrud.Infrastructure.Adapters.Mapper.Interfaces
{
    public interface IClientMapper
    {
        Client MapperToEntity(ClientDto clientDto);

        Client MapperToEntity(ClientCreateDto clientDto);

        IEnumerable<ClientDto> MapperClientList(IEnumerable<Client> clients);

        IEnumerable<ClientViewDto> MapperClientViewList(IEnumerable<Client> clients);

        ClientDto MapperToDto(Client client);

        ClientViewDto MapperToViewDto(Client client);
    }
}
