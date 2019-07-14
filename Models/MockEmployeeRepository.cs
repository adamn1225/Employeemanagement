using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Adam", Department = "Husband", Email = "adam@gmail.com"}
                new Employee() { Id = 2, Name = "Sharon", Department = "Wife", Email = "Sharon@gmail.com"}
                new Employee() { Id = 3, Name = "Adam", Department = "Dog", Email = "Pudge@gmail.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return this._employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
