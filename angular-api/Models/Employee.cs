using System;

namespace CompanyAPI.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string MobNo { get; set; } = string.Empty;
    }
}
