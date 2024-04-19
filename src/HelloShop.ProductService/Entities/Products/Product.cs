﻿namespace HelloShop.ProductService.Entities.Products
{
    public class Product
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; } = default!;

        public string? ImageUrl { get; set; }

        public DateTimeOffset CreationTime { get; init; } = TimeProvider.System.GetUtcNow();
    }
}