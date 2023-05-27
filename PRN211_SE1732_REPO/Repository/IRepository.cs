using PRN211_SE1732_REPO.Entities;

namespace PRN211_SE1732_REPO.Repository;

public interface IRepository
{
    Product[] GetAll();
    Product Get(int id);
    void Add(Product product);
    void Update(Product product);
    void Delete(Product product);
    void Delete(int id);
    void Display();
}
