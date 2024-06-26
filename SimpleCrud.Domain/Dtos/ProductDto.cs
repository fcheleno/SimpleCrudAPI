﻿using System.ComponentModel.DataAnnotations;

namespace SimpleCrud.Domain.Dtos
{
    public class ProductDto
    {
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Value { get; set; }

        [Required]
        public int ClientId { get; set; }
    }
}
