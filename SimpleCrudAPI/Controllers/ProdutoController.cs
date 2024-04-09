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
        /// Recuperar Produto por Id
        /// </summary>
        /// <param name="id">Id do Produto</param>
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_applicationProductService.GetById(id));
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(_applicationProductService.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _applicationProductService.Add(productDto);
                return Ok("Produto cadastrado com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

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
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _applicationProductService.Remove(productDto);
                return Ok("Produto removido com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
