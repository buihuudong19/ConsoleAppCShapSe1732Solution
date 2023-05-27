using ConsoleAppOopDemo.Domain;
using ConsoleAppOopDemo.Entities;

namespace ConsoleAppOopDemo;

public class Program
{
    static void Main(string[] args)
    {
        /*
        Num n1 = new Num(13, 12);
        n1.Num01 = 1;

        Num n = new Num(6);

        Console.WriteLine(n.Factorial());
        */

        Student s1 = new Student(1,"Ma Van Meo","Quan 10",5.5);
        s1.Mark = 7.5;
        Student s2 = new Student(2, "Nguyen Van A", "Quan 10", 4.5);
        Student s3 = new Student(3, "Tran Thi B", "Quan 10", 9.5);
        Student s4 = new Student(4, "Hot Tat Liet", "Quan 10", 2.5);

        StudentManager sM = new StudentManager();

        sM.AddStudent(s1);
        sM.AddStudent(s2);
        sM.AddStudent(s3);
        sM.AddStudent(s4);


        sM.Display();


        
    }
}

/*
    Viet chuong trinh quan ly sinh vien (id, name, address, mark)
    - cho phep them nhieu sinh vien
    - in ra all sinh vien
    - update 1 sinh vien bat ky theo id
    - sap xep tang dan theo diem cua sinh vien va in ra man hinh
 
 */