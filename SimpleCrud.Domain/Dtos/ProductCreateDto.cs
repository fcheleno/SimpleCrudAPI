using System.ComponentModel.DataAnnotations;

namespace SimpleCrud.Domain.Dtos
{
    public class ProductCreateDto
    {
        [Required]
        public string Name { get; set; }
        
        public decimal Value { get; set; }
        
        [Required]
        public int ClientId { get; set; }
    }
}
