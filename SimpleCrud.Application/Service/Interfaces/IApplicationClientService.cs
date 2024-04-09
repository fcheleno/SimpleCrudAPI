using SimpleCrud.Domain.Dtos;

namespace SimpleCrud.Application.Service.Interfaces
{
    public interface IApplicationClientService
    {
        ClientDto GetById(int id);

        IEnumerable<ClientDto> GetAll();

        void Add(ClientDto obj);

        void Update(ClientDto obj);

        void Remove(ClientDto obj);

        void Dispose();
    }
}
