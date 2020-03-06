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
    public class indexModel : PageModel
    {
        public IEnumerable <Employee>  Employees { get; set; }

        private readonly IEmployeeRepository empRepository;
        public indexModel(IEmployeeRepository empRepository)
        {
            this.empRepository = empRepository;
        }

        public void OnGet()
        {
            Employees = empRepository.GetAllEmployees();
        }
    }
}