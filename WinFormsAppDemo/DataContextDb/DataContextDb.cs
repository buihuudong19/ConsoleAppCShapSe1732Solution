using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using WinFormsAppDemo.Entities;

namespace WinFormsAppDemo.DataContext;

public class DataContextDb
{
    //đọc được chuỗi kết nối đến DB tương ứng
    private string _conStr;
    //ado.net
    private SqlConnection _connection;
    private SqlCommand _command;
    private SqlDataReader _reader;

    public DataContextDb()
    {
        _conStr = _getConn();
        _connection = new SqlConnection(_conStr);
    }


    public IList<Employee> GetEmployees()
    {
        string vSQL = "select * from Employees";
        List<Employee> employees = new List<Employee>();
        try
        {
            _connection.Open();
            _command=new SqlCommand(vSQL,_connection);
            _reader = _command.ExecuteReader(CommandBehavior.CloseConnection);
            if( _reader != null && _reader.HasRows)
            {
                while( _reader.Read())
                {
                    Employee e = new Employee();    
                    e.Id = _reader.GetInt32("EmpId");
                    e.Name = _reader.GetString("FullName");
                    e.DepartmentId = _reader.GetInt32("DepartmentId");
                    e.Dob = _reader.GetDateTime("Dob");
                    e.WorkingDay = _reader.GetInt32("WorkingDay");
                    e.RateSalary = _reader.GetDouble("SalaryRate");

                    employees.Add(e);


                }

            }
          
            return employees;

        }
        catch (Exception ex)
        {
            return null;
        }
        finally {
            _connection.Close();
            _command.Dispose();
        }
    }

    public void AddEmployee(Employee e)
    {
        if(_connection.State != ConnectionState.Open)
        {
            _connection.Open();
        }
        try
        {
            _command = new SqlCommand("insert into employees values(@Id, @Name, @Dob, @DepartmentId, @WorkingDay, @SalaryRate)", _connection);

            _command.Parameters.Add("@Id",SqlDbType.Int).Value = e.Id;
            _command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = e.Name;
            _command.Parameters.Add("@Dob", SqlDbType.DateTime).Value = e.Dob;
            _command.Parameters.Add("@DepartmentId", SqlDbType.Int).Value = e.DepartmentId;
            _command.Parameters.Add("@WorkingDay", SqlDbType.Int).Value = e.WorkingDay;
            _command.Parameters.Add("@SalaryRate", SqlDbType.Decimal).Value = e.RateSalary;

            _command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            
        }
        finally { 
            
            _command.Dispose(); 
        }

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
