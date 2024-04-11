using Microsoft.AspNetCore.Mvc;
using SimpleCrud.Application.Service.Interfaces;
using SimpleCrud.Domain.Dtos;
using System.Net;

namespace SimpleCrudAPI.Controllers
{
    /// <summary>
    /// Products Controller
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IApplicationProductService _applicationProductService;

        public ProductsController(ILogger<ProductsController> logger, IApplicationProductService applicationProductService)
        {
            _logger = logger;
            _applicationProductService = applicationProductService;
        }

        /// <summary>
        /// Recuperar o Produto por Id
        /// </summary>
        /// <param name="id">Id do Produto</param>
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

                var product = _applicationProductService.GetById(id);

                if (product.Id == null)
                    return NotFound();

                return Ok(product);
            }
            catch (Exception error)
            {
                _logger.LogError(error.Message);
                throw;
            }
        }

        /// <summary>
        /// Recuperar todos os Produtos cadastrados
        /// </summary>
        [HttpGet("All-Products")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult GetAll()
        {            
            try
            {
                return Ok(_applicationProductService.GetAll());
            }
            catch (Exception error)
            {
                _logger.LogError(error.Message);
                throw;
            }
        }

        /// <summary>
        /// Cadastrar o Produto 
        /// </summary>
        /// <param name="Name">Nome do Produto</param>
        /// <param name="value">Valor do Produto</param>
        /// <param name="ClientId">ClientId do Produto</param>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult Post([FromBody] ProductCreateDto productDto)
        {
            try
            {
                if (productDto == null)
                    return BadRequest();

                _applicationProductService.Add(productDto);
                return Ok("Produto cadastrado com sucesso!");
            }
            catch (Exception error)
            {
                _logger.LogError(error.Message);
                throw;
            }
        }

        /// <summary>
        /// Atualizar o Produto 
        /// </summary>
        /// <param name="id">Id do Produto</param>
        /// <param name="Name">Nome do Produto</param>
        /// <param name="value">Valor do Produto</param>
        /// <param name="ClientId">ClientId do Produto</param>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult Put([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return BadRequest();

                _applicationProductService.Update(productDto);
                return Ok("Produto atualizado com sucesso!");
            }
            catch (Exception error)
            {
                _logger.LogError(error.Message);
                throw;
            }
        }

        /// <summary>
        /// Excluir o Produto 
        /// </summary>
        /// <param name="id">Id do Produto</param>
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

                var productDto = new ProductDto();
                productDto.Id = id;                

                _applicationProductService.Remove(productDto);
                return Ok("Produto removido com sucesso!");
            }
            catch (Exception error)
            {
                _logger.LogError(error.Message);
                throw;
            }
        }
    }
}
