using System.ComponentModel.DataAnnotations;

namespace SimpleCrud.Domain.Dtos
{
    public class ClientCreateDto
    {
        [Required]
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Mail { get; set; }
    }
}
