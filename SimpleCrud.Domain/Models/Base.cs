namespace SimpleCrud.Domain.Models
{
    public class Base
    {
        public int? Id { get; set; } 
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public bool Active { get; set; } = true;
    }
}
