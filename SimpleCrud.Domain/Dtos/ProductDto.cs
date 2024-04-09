namespace SimpleCrud.Domain.Dtos
{
    public class ProductDto
    {
        public int? Id { get; set; } 

        public string Name { get; set; }

        public decimal Value { get; set; }

        public int ClientId { get; set; }
    }
}
