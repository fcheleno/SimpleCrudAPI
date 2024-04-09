namespace SimpleCrud.Domain.Models
{
    public class Product : Base
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
