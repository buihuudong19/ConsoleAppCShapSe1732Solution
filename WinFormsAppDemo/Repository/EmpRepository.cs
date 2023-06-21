
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
    {
        throw new NotImplementedException();
    }

    public void Delete(Employee e)
    {
        throw new NotImplementedException();
    }

    public Employee Get(int id)
    {
        throw new NotImplementedException();
    }

    public IList<Employee> GetAll()
    {
        return _db.GetEmployees();
    }

    public void Update(Employee e)
    {
        throw new NotImplementedException();
    }
}
