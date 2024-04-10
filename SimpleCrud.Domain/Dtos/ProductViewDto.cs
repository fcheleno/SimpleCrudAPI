namespace SimpleCrud.Domain.Dtos
{
    public class ProductViewDto
    {
        public int? Id { get; set; } 
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int ClientId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
