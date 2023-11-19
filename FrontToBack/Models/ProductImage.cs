namespace FrontToBack.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Alternative { get; set; }
        public bool IsPrimary { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int NEwProductId { get; set; }
        public NewProduct NewProduct { get; set; }


    }
}
