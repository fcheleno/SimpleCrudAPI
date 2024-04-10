namespace SimpleCrud.Domain.Models
{
    public class Base
    {
        public int? Id { get; set; } 
        public DateTime CreateDate { get; set; } 
        public DateTime? UpdateDate { get; set; }
    }
}
