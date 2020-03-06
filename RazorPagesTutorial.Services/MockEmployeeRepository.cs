using System;
using System.Collections.Generic;
using System.Text;
using RazorPagesTutorial.Models;

namespace RazorPagesTutorial.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeesList;
        public MockEmployeeRepository()
        {
            _employeesList = new List<Employee>()
            {
                new Employee (){Id=1, Name="Mike Cohen", Departement= Dept.Finances, Email="Cohen.mhn.com",PhotoPath="cohen.jpg"},
                 new Employee (){Id=1, Name="Jean Michel", Departement= Dept.Finances, Email="michel.mhn.com",PhotoPath="michel.jpg"},
                  new Employee (){Id=1, Name="Marie André", Departement= Dept.Finances, Email="marie.mhn.com",PhotoPath="marie.jpg"},
                   new Employee (){Id=1, Name="John Doe", Departement= Dept.Finances, Email="doe.mhn.com",PhotoPath="doe.jpg"}

            };
        }
        IEnumerable<Employee> IEmployeeRepository.GetAllEmployees()
        {
            return _employeesList;
        }
    }
}
