using SimpleCrud.Domain.Dtos;

namespace SimpleCrud.Application.Service.Interfaces
{
    public interface IApplicationClientService
    {
        ClientViewDto GetById(int id);

        IEnumerable<ClientViewDto> GetAll();

        void Add(ClientCreateDto obj);

        void Update(ClientDto obj);

        void Remove(ClientDto obj);

        void Dispose();
    }
}
