
using WinFormsAppDemo.Entities;
using WinFormsAppDemo.DataContext;

namespace WinFormsAppDemo.Repository;

public class EmpRepository : IEmpRepository
{
    //ado.net => database?
    private DataContextDb _db;

    public EmpRepository()
    {
        _db = new DataContextDb();
    }

    public void Add(Employee e)
    => _db.AddEmployee(e);

    public void Delete(Employee e)
    {
        throw new NotImplementedException();
    }

    public Employee Get(int id)
    {
        throw new NotImplementedException();
    }

    public IList<Employee> GetAll()
            => _db.GetEmployees();//bodied-expression

    public void Update(Employee e)
    {
        throw new NotImplementedException();
    }
}
