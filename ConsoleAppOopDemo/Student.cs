
namespace ConsoleAppOopDemo.Domain;
public class Student
{
    //1. properties
    public int? Id { get; set; } = null;
    public string? Name { get; set; }
    public string? Address { get; set; }
    public double Mark { get; set; }

    //2. constructors
    public Student()
    {
   
    }
    public Student(int? id, string? name, string? address, double mark)
    {
        Id = id;
        Name = name;
        Address = address;
        Mark = mark;
    }
    //3. manual methods
    public override string? ToString()
        => $"Id: {Id}, Name:{Name}, Address: {Address} and Mark: {Mark}";
    
    

}
