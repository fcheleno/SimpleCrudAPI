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
            try
            {
                if (id == 0)
                    return NotFound();

                return Ok(_applicationClientService.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Recuperar todos os Clientes cadastrados
        /// </summary>
        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(_applicationClientService.GetAll());
        }

        /// <summary>
        /// Cadastrar o Cliente 
        /// </summary>
        /// <param name="Name">Nome do Cliente</param>
        /// <param name="LastName">Sobrenome do Cliente</param>
        /// <param name="Mail">Mail do Cliente</param>
        [HttpPost]
        public IActionResult Post([FromBody] ClientCreateDto clientDto)
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
                return BadRequest(ex.Message);
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
        public IActionResult Put([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                _applicationClientService.Update(clientDto);
                return Ok("Cliente atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Excluir o Cliente 
        /// </summary>
        /// <param name="id">Id do Cliente</param>
        [HttpDelete]
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
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
