using SimpleCrud.Domain.Dtos;
using SimpleCrud.Domain.Models;
using SimpleCrud.Infrastructure.Adapters.Mapper.Interfaces;

namespace SimpleCrud.Infrastructure.Adapters.Mapper
{
    public class ClientMapper : IClientMapper
    {
        List<ClientDto> clientListDto = new List<ClientDto>();
        List<ClientViewDto> clientViewListDto = new List<ClientViewDto>();

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

        public Client MapperToEntity(ClientCreateDto clientDto)
        {
            var client = new Client
            {
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

        public IEnumerable<ClientViewDto> MapperClientViewList(IEnumerable<Client> clients)
        {
            foreach (var c in clients)
            {
                var clientViewDto = new ClientViewDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    LastName = c.LastName,
                    Mail = c.Mail,
                    CreateDate = c.CreateDate,
                    UpdateDate = c.UpdateDate,
                };

                clientViewListDto.Add(clientViewDto);
            }

            return clientViewListDto;
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

        public ClientViewDto MapperToViewDto(Client client)
        {
            var clientViewDto = new ClientViewDto
            {
                Id = client.Id,
                Name = client.Name,
                LastName = client.LastName,
                Mail = client.Mail,
                CreateDate = client.CreateDate,
                UpdateDate = client.UpdateDate,
            };

            return clientViewDto;
        }
    }
}
