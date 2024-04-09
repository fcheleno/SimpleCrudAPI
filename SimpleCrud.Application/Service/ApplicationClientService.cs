﻿using SimpleCrud.Application.Service.Interfaces;
using SimpleCrud.Core.Interfaces.Services;
using SimpleCrud.Domain.Dtos;
using SimpleCrud.Infrastructure.Adapters.Mapper.Interfaces;

namespace SimpleCrud.Application.Service
{
    public class ApplicationClientService : IDisposable, IApplicationClientService
    {
        private readonly IClientService _clientService;
        private readonly IClientMapper _clientMapper;

        public ApplicationClientService(IClientService clientService, IClientMapper clientMapper)
        {
            _clientService = clientService;
            _clientMapper = clientMapper;
        }

        public ClientDto GetById(int id)
        {
            var client = _clientService.GetById(id);
            return _clientMapper.MapperToDto(client);
        }

        public IEnumerable<ClientDto> GetAll()
        {
            var clients = _clientService.GetAll();
            return _clientMapper.MapperClientList(clients);
        }   

        public void Add(ClientDto clientDto)
        {
            var client = _clientMapper.MapperToEntity(clientDto);
            _clientService.Add(client);
        }

        public void Update(ClientDto clientDto)
        {
            var client = _clientMapper.MapperToEntity(clientDto);
            _clientService.Update(client);
        }

        public void Remove(ClientDto clientDto)
        {
            var client = _clientMapper.MapperToEntity(clientDto);
            _clientService.Remove(client);
        }

        public void Dispose()
        {
            _clientService.Dispose();
        }
    }
}