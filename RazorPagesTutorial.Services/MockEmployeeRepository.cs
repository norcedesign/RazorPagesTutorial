using System;
using System.Collections.Generic;
using System.Linq;
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
                 new Employee (){Id=2, Name="Jean Michel", Departement= Dept.Finances, Email="michel.mhn.com",PhotoPath="michel.jpg"},
                  new Employee (){Id=3, Name="Marie André", Departement= Dept.Finances, Email="marie.mhn.com",PhotoPath="marie.jpg"},
                   new Employee (){Id=4, Name="John Doe", Departement= Dept.Finances, Email="doe.mhn.com",PhotoPath="doe.jpg"}

            };
        }
        IEnumerable<Employee> IEmployeeRepository.GetAllEmployees()
        {
            return _employeesList;
        }

        Employee IEmployeeRepository.GetEmployee(int id)
        {
           return _employeesList.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
