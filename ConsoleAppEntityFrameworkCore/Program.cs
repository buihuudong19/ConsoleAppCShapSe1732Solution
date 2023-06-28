using ConsoleAppEntityFrameworkCore.ModelsEntities;
using ConsoleAppEntityFrameworkCore.Repository;

IRepository repository = new Repository();

IList<Employee> emps = repository.GetAll();


Employee a = new Employee();
a.EmpId = 6;
a.FullName = "Nguyen Cong Phuong";
a.WorkingDay = 20;
a.SalaryRate = 10;
a.Dob = new DateTime(1987,12,20);
a.DepartmentId = 2;

repository.Add(a);  


foreach (var e in emps)
{
    Console.WriteLine(e.FullName);
}