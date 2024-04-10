using Microsoft.AspNetCore.Mvc;
using SimpleCrud.Application.Service.Interfaces;
using SimpleCrud.Domain.Dtos;

namespace SimpleCrudAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ILogger<ProdutoController> _logger;
        private readonly IApplicationProductService _applicationProductService;

        public ProdutoController(ILogger<ProdutoController> logger, IApplicationProductService applicationProductService)
        {
            _logger = logger;
            _applicationProductService = applicationProductService;
        }

        /// <summary>
        /// Recuperar o Produto por Id
        /// </summary>
        /// <param name="id">Id do Produto</param>
        [HttpGet]
        public IActionResult Get(int id)
        {
            try
            {
                if (id == 0)
                    return NotFound();

                return Ok(_applicationProductService.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Recuperar todos os Produtos cadastrados
        /// </summary>
        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(_applicationProductService.GetAll());
        }

        /// <summary>
        /// Cadastrar o Produto 
        /// </summary>
        /// <param name="Name">Nome do Produto</param>
        /// <param name="value">Valor do Produto</param>
        /// <param name="ClientId">ClientId do Produto</param>
        [HttpPost]
        public IActionResult Post([FromBody] ProductCreateDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _applicationProductService.Add(productDto);
                return Ok("Produto cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
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
        public IActionResult Put([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _applicationProductService.Update(productDto);
                return Ok("Produto atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Excluir o Produto 
        /// </summary>
        /// <param name="id">Id do Produto</param>
        [HttpDelete]
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
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
