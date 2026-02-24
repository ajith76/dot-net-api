using System.Collections.Generic;
using CompanyAPI.Models;

namespace CompanyAPI.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        Employee? GetById(int id);
    }
}
