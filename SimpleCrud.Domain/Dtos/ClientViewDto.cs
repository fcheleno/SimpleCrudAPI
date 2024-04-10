namespace SimpleCrud.Domain.Dtos
{
    public class ClientViewDto
    {
        public int? Id { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public DateTime CreateDate { get; set; } 
        public DateTime? UpdateDate { get; set; }
    }
}
