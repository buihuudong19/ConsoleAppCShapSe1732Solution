using PRN211_SE1732_REPO.Entities;
using PRN211_SE1732_REPO.Repository;

namespace ConsoleAppProductPRN211.Programming;

public class Program
{
    static void Main(string[] args)
    {
        IRepository repository = new Repository();

        Product p1 = new(1,"Ram Gigabyte","Ram moi nhat nam 2023",60);
        Product p2 = new(2, "Ram Gigabyte", "Ram moi nhat nam 2023",60);
        Product p3 = new(3, "Ram Gigabyte", "Ram moi nhat nam 2023", 50);
        Product p4 = new(4, "Ram Gigabyte", "Ram moi nhat nam 2023", 40);

        Product p5 = new(5, "Ram Gigabyte", "Ram moi nhat nam 2023", 40);
        Product p6 = new(6, "Ram Gigabyte", "Ram moi nhat nam 2023", 30);

        repository.Add(p1);
        repository.Add(p2);
        repository.Add(p3);
        repository.Add(p4);
        repository.Add(p5);
        repository.Add(p6);

        /*
        Product[] products = repository.GetAll();
        Console.WriteLine(products.Length);
        */
        repository.Display();

    }


    public static void ShowTop(Product[] products)
    {
        //hien thi top 3 san pham co price lon nhat
    }
}