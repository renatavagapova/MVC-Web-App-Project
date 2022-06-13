namespace MVC_Web_App_Project.Models
{
    public class AddProduct
    {
        public List<Category> Categories { get; set; } = new();
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
