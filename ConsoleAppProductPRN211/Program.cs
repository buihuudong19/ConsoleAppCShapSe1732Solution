using PRN211_SE1732_REPO.Entities;
using PRN211_SE1732_REPO.Repository;

namespace ConsoleAppProductPRN211.Programming;

public class Program
{
    static void Main(string[] args)
    {
        IRepository repository = new Repository();

        Product p1 = new(1,"Ram Gigabyte","Ram moi nhat nam 2023",123.55d);
        Product p2 = new(2, "Ram Gigabyte", "Ram moi nhat nam 2023", 23);
        Product p3 = new(3, "Ram Gigabyte", "Ram moi nhat nam 2023", 144.55d);
        Product p4 = new(4, "Ram Gigabyte", "Ram moi nhat nam 2023", 2.55d);

        repository.Add(p1);
        repository.Add(p2);
        repository.Add(p3);
        repository.Add(p4);

        /*
        Product[] products = repository.GetAll();
        Console.WriteLine(products.Length);
        */
        repository.Display();

    }
}