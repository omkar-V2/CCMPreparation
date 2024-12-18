﻿using EmployeeManagement.Data;
using EmployeeManagement.Model;

namespace EmployeeManagement.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee Add(Employee employee)
        {
            var result = _employeeRepository.Add(employee);
            return result;
        }

        public int Update(Employee employee)
        {
            return _employeeRepository.Update(employee);
        }

        public int Delete(int employeeId)
        {
            return _employeeRepository.Delete(employeeId);
        }

        public IEnumerable<Employee> GetAll()
        {

            return _employeeRepository.GetAll();
        }

        public IEnumerable<Employee> SearchEmployee(string firstName)
        {
            return _employeeRepository.SearchEmployee(firstName);
        }

        public IEnumerable<Employee> SearchEmployee(int id)
        {
            return _employeeRepository.SearchEmployee(id);
        }


        public decimal GetAverageSalaryOfDepartment(string departmentName)
        {
            return _employeeRepository.GetAverageSalaryOfDepartment(departmentName);
        }

        public IEnumerable<object> GetAllLocationsOfDepartment(string departmentName)
        {
            return _employeeRepository.GetAllLocationsOfDepartment(departmentName);
        }

        public IEnumerable<object> GetEmployeeCountOfAllDepartment()
        {
            return _employeeRepository.GetEmployeeCountOfAllDepartment();
        }

        public IEnumerable<object> GetRecent5Employees()
        {
            return _employeeRepository.GetRecent5Employees();
        }

    }
}
