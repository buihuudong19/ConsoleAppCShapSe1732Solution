
namespace WinFormsAppDemo.Entities;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Dob { get; set; }
    public int DepartmentId { get; set; }
    public int WorkingDay { get; set; }
    public double RateSalary { get; set; }

    public Employee()
    {
    }

    public Employee(int id, string name, DateTime dob, int departmentId, int workingDay, double rateSalary)
    {
        Id = id;
        Name = name;
        Dob = dob;
        DepartmentId = departmentId;
        WorkingDay = workingDay;
        RateSalary = rateSalary;
    }
}
