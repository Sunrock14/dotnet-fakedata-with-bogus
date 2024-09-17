using System.Collections.Generic;

namespace FakeData.App.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    // Kategorinin ürünlerle ilişkisi
    public virtual ICollection<Product> Products { get; set; }
}