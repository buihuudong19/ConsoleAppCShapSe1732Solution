using PRN211_SE1732_REPO.Entities;

namespace PRN211_SE1732_REPO.Repository;

public class Repository : IRepository
{
    private Product[] _products;
    private int _size;

    public Repository()
    {
        _products = new Product[2];
        _size = 0;

    }
    public void Add(Product product)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product product)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public void Display()
    {
        throw new NotImplementedException();
    }

    public Product Get(int id)
    {
        throw new NotImplementedException();
    }

    public Product[] GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(Product product)
    {
        throw new NotImplementedException();
    }

    public int Count() => _size;
    public bool isFull() => _size >= _products.Length;
}