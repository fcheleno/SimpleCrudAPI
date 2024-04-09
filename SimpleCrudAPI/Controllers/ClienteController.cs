using Microsoft.AspNetCore.Mvc;
using SimpleCrud.Application.Service.Interfaces;
using SimpleCrud.Domain.Dtos;

namespace SimpleCrudAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly IApplicationClientService _applicationClientService;

        public ClienteController(ILogger<ClienteController> logger, IApplicationClientService applicationClientService)
        {
            _logger = logger;
            _applicationClientService = applicationClientService;
        }       

        /// <summary>
        /// Recuperar Cliente por Id
        /// </summary>
        /// <param name="id">Id do Cliente</param>
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_applicationClientService.GetById(id));
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(_applicationClientService.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                _applicationClientService.Add(clientDto);
                return Ok("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                _applicationClientService.Update(clientDto);
                return Ok("Cliente atualizado com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                _applicationClientService.Remove(clientDto);
                return Ok("Cliente removido com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
