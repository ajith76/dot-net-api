using System.Collections.Generic;
using System.Linq;
using CompanyAPI.Models;

namespace CompanyAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> _employees = new()
        {
            new Employee { EmployeeId = 1, Name = "Ajith", Age = 30, MobNo = "555-0101" },
            new Employee { EmployeeId = 2, Name = "Rahul", Age = 28, MobNo = "555-0102" },
            new Employee { EmployeeId = 3, Name = "Kumar", Age = 35, MobNo = "555-0103" }
        };

        private readonly object _lock = new();

        public IEnumerable<Employee> GetAll()
        {
            lock (_lock)
            {
                return _employees.ToList();
            }
        }

        public Employee? GetById(int id)
        {
            lock (_lock)
            {
                return _employees.FirstOrDefault(e => e.EmployeeId == id);
            }
        }

        public Employee Add(Employee employee)
        {
            lock (_lock)
            {
                var nextId = _employees.Any() ? _employees.Max(e => e.EmployeeId) + 1 : 1;
                employee.EmployeeId = nextId;
                _employees.Add(employee);
                return employee;
            }
        }
    }
}
