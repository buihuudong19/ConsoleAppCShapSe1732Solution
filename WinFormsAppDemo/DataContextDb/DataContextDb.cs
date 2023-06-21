using Microsoft.Extensions.Configuration;
using WinFormsAppDemo.Entities;

namespace WinFormsAppDemo.DataContext;

public class DataContextDb
{
    //đọc được chuỗi kết nối đến DB tương ứng
    private string _conStr;

    public DataContextDb()
    {
        _conStr = _getConn();
    }


    public IList<Employee> GetEmployees()
    {
        return null;
    }

    public void AddEmployee(Employee e)
    {

    }
    public void UpdateEmployee(Employee e)
    {

    }
    public void DeleteEmployee(Employee e)
    {

    }



    //doc tu file appsetting.json

    private string _getConn()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json",true,true)
            .Build();

        return config["ConnectionStrings:HRManagementDb"];

    }
}
