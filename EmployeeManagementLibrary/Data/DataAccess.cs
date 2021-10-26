using EmployeeManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Data
{
    public class DataAccess : IDataAccess
    {
        private List<EmployeeModel> _employees = new();

        public DataAccess()
        {
            _employees.Add(new EmployeeModel { Id = 1, FirstName = "Ramesh", LastName = "Shah" });
            _employees.Add(new EmployeeModel { Id = 2, FirstName = "Umesh", LastName = "Shah" });
        }
        public EmployeeModel AddEmployees(string firstName, string lastName)
        {
            EmployeeModel employeeModel = new() { FirstName = firstName, LastName = lastName };
            employeeModel.Id = _employees.Max(x => x.Id) + 1;
            return employeeModel;
        }

        public List<EmployeeModel> GetEmployees()
        {
            return _employees;
        }
    }
}
