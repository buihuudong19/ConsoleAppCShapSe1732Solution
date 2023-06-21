using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppDemo.Entities;

namespace WinFormsAppDemo.Repository;

public interface IEmpRepository
{
    IList<Employee> GetAll();
    Employee Get(int id);
    void Add(Employee e);
    void Update(Employee e);
    void Delete(Employee e);
}
