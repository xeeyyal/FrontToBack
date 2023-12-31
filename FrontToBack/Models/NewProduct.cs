﻿namespace FrontToBack.Models
{
    public class NewProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public  string SKU { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ProductImage>? ProductImages { get; set; }


    }
}
