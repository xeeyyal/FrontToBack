﻿namespace FrontToBack.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Order { get; set; }
        public List<ProductImage>? ProductImages { get; set; }
    }
}
