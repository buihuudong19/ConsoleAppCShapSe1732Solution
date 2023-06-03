using PRN211_SE1732_REPO.Entities;

namespace PRN211_SE1732_REPO.Repository;

public class Repository : IRepository
{
    private List<Product> _products;
  

    public Repository()
    {
        _products = new(); //c# version 9.0
       

    }
    public void Add(Product product)
        => _products.Add(product); //bodied expression


    public void Delete(Product product)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        var p = _products.Find(p => p.Id.Equals(id));
        if (p != null) 
            _products.Remove(p);
   
    }

    public void Display()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product);
        }
    }
   
    public Product? Get(int id)
        => _products
                .FirstOrDefault(p=> p.Id == id);

    

    public IEnumerable<Product> GetAll() 
        => _products; //expresion bodied

    public void Sort()
    {
        _products = _products.OrderBy(p => p.Price)
            .ToList();
    }

    public double Sum()
        => _products.Sum(p => p.Price);

    public void Update(Product product)
    {
        int index = _products.IndexOf(product);
        _products[index]= product;
    }

}