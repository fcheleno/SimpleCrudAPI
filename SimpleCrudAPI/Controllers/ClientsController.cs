using Microsoft.AspNetCore.Mvc;
using SimpleCrud.Application.Service.Interfaces;
using SimpleCrud.Domain.Dtos;
using System.Net;

namespace SimpleCrudAPI.Controllers
{
    /// <summary>
    /// Clients Controller
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly ILogger<ClientsController> _logger;
        private readonly IApplicationClientService _applicationClientService;

        public ClientsController(ILogger<ClientsController> logger, IApplicationClientService applicationClientService)
        {
            _logger = logger;
            _applicationClientService = applicationClientService;
        }       

        /// <summary>
        /// Recuperar Cliente por Id
        /// </summary>
        /// <param name="id">Id do Cliente</param>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult Get(int id)
        {
            try
            {
                if (id == 0)
                    return NotFound();

                var client = _applicationClientService.GetById(id);

                if (client.Id == null)
                    return NotFound();

                return Ok(client);
            }
            catch (Exception error)
            {
                _logger.LogError(error.Message);
                throw;
            }
        }

        /// <summary>
        /// Recuperar todos os Clientes cadastrados
        /// </summary>
        [HttpGet("All-Clients")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_applicationClientService.GetAll());
            }
            catch (Exception error)
            {
                _logger.LogError(error.Message);
                throw;
            }
        }

        /// <summary>
        /// Cadastrar o Cliente 
        /// </summary>
        /// <param name="Name">Nome do Cliente</param>
        /// <param name="LastName">Sobrenome do Cliente</param>
        /// <param name="Mail">Mail do Cliente</param>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult Post([FromBody] ClientCreateDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return BadRequest();

                _applicationClientService.Add(clientDto);
                return Ok("Cliente cadastrado com sucesso!");
            }
            catch (Exception error)
            {
                _logger.LogError(error.Message);
                throw;
            }
        }

        /// <summary>
        /// Atualizar o Cliente 
        /// </summary>
        /// <param name="id">Id do Cliente</param>
        /// <param name="Name">Nome do Cliente</param>
        /// <param name="LastName">Sobrenome do Cliente</param>
        /// <param name="Mail">Mail do Cliente</param>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult Put([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return BadRequest();

                _applicationClientService.Update(clientDto);
                return Ok("Cliente atualizado com sucesso!");
            }
            catch (Exception error)
            {
                _logger.LogError(error.Message);
                throw;
            }
        }

        /// <summary>
        /// Excluir o Cliente 
        /// </summary>
        /// <param name="id">Id do Cliente</param>
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult Delete(int id)
        {
            try
            {
                if (id == 0)
                    return NotFound();

                var clientDto = new ClientDto();
                clientDto.Id = id;                    

                _applicationClientService.Remove(clientDto);
                return Ok("Cliente removido com sucesso!");
            }
            catch (Exception error)
            {
                _logger.LogError(error.Message);
                throw;
            }
        }
    }
}
