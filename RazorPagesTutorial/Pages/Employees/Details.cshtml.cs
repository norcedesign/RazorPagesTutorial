using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesTutorial.Models;
using RazorPagesTutorial.Services;

namespace RazorPagesTutorial.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        public IEmployeeRepository employeeRepository { get; set; }
        public Employee Employee { get; set; }
        public DetailsModel(IEmployeeRepository employeeRepository)
        {
           this.employeeRepository = employeeRepository;
        }
        public void OnGet(int Id=1)
        {
            Employee = employeeRepository.GetEmployee(Id); //GetAllEmployees().Where(e => e.Id == Id).FirstOrDefault();
        }
    }
}