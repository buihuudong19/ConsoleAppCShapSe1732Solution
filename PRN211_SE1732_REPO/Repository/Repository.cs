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
        if (isFull())
        {
            Product[] temp = new Product[2 * Count()];
            Array.Copy(_products, 0, temp, 0, _size);
            _products = temp;
        }
        _products[_size++] = product;
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
        foreach (Product product in _products)
        {
            Console.WriteLine(product);
        }
    }

    public Product Get(int id)
    {
        throw new NotImplementedException();
    }

    public Product[] GetAll() => _products; //expresion bodied


    public void Update(Product product)
    {
        throw new NotImplementedException();
    }

    public int Count() => _size;
    public bool isFull() => _size >= _products.Length;
}