namespace ConsoleAppCShapSe1732.Programming;//domain A.B

public class Program
{
    public static void Main(string[] args)
    {
        int a = 10;
        double b = 20;
        int n = 0;
        Console.WriteLine($"Total hai so x va y la: {Add(a,b,3)}");
        Console.Write("Hay nhap n = ");
        n = int.Parse(Console.ReadLine() );    

        Console.WriteLine($"Tong tu 1 den {n} la: {Sum(n)}");
    }
    //lambda 
    public static int Add(int x, int y) => x + y;
    //overloading: nap chong/qua tai (methods)
    public static double Add(int x, double y) => x + y;
    public static double Add(double x, double y) => x + y;
    public static double Add(int x, double y, double z) => Add(Add(x, y), z);

    //Tinh tong cac so chan trong day so: 1+2+3+...+n voi n nhap tu ban phim

    public static long Sum(int n)
    {
        long sum = 0;
        int i = 1;
        //do..while, for, recursion, /
        while (i <= n)
        {
            if(i % 2 == 0)
            sum += i;//sum = sum + i; -=, /=, %=, *=
            i++;//i=i+1
        }
        return sum;
    }

    //Tinh tong theo kieu de quy

    public static long Total(int  n)
    {
        if (n == 0||n==1) return n;//dieu kien dung
        return n + Total(n - 1);
    }

    //Bai tap thuc hanh:
    /*
        1. Tim uoc chung lon nhat cua 2 so a va b theo 2 phuong phap
        - Lap thong thuong
        - Theo de quy (Euclid)
        
        2. Tinh tong day so sau: 1+1/3+1/5+1/7 +..+1/(2n+1)
     
     */









  

}

