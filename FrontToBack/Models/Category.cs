namespace FrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NewProduct>? NewProducts { get; set; }
    }
}
