
namespace PRN211_SE1732_REPO.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public Product()
    {
       
    }
    public Product(int id, string name, string description, double price)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
    }

    public override string? ToString() => $"Id: {Id}, Name: " +
        $"{Name}, Desc: {Description} and Price: {Price}";
    
}
