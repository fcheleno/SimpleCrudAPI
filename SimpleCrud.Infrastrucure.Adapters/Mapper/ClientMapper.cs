using SimpleCrud.Domain.Dtos;
using SimpleCrud.Domain.Models;
using SimpleCrud.Infrastructure.Adapters.Mapper.Interfaces;

namespace SimpleCrud.Infrastructure.Adapters.Mapper
{
    public class ClientMapper : IClientMapper
    {
        List<ClientDto> clientListDto = new List<ClientDto>();

        public Client MapperToEntity(ClientDto clientDto)
        {
            var client = new Client
            {
                Id = clientDto.Id,
                Name = clientDto.Name,
                LastName = clientDto.LastName,
                Mail = clientDto.Mail,
            };

            return client;
        }

        public IEnumerable<ClientDto> MapperClientList(IEnumerable<Client> clients)
        {
            foreach (var c in clients)
            {
                var clientDto = new ClientDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    LastName = c.LastName, 
                    Mail = c.Mail,
                };

                clientListDto.Add(clientDto);
            }

            return clientListDto;
        }

        public ClientDto MapperToDto(Client client)
        {
            var clientDto = new ClientDto
            {
                Id = client.Id,
                Name = client.Name,
                LastName = client.LastName,
                Mail = client.Mail,
            };

            return clientDto;
        }
    }
}
