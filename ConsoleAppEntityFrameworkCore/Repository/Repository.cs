using ConsoleAppEntityFrameworkCore.ModelsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFrameworkCore.Repository
{
    public class Repository : IRepository
    {
        private readonly HRManagementDBContext _dbContext;

        public Repository()
        {
            _dbContext = new HRManagementDBContext();
        }

        public void Add(Employee e)
        {
            _dbContext.Employees.Add(e);
            _dbContext.SaveChanges();
        }

        public void Delete(Employee e)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAll() => _dbContext.Employees.ToList();
        public void Update(Employee e)
        {
            throw new NotImplementedException();
        }
    }
}
