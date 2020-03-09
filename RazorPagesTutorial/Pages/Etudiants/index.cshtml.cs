using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesTutorial.Models;
using RazorPagesTutorial.Services;

namespace RazorPagesTutorial.Pages.Etudiants
{
    public class indexModel : PageModel
    {
        public IEnumerable <Etudiant>  Etudiants { get; set; }

        private readonly IEtudiantRepository empRepository;
        public indexModel(IEtudiantRepository empRepository)
        {
            this.empRepository = empRepository;
        }

        public void OnGet()
        {
            Etudiants = empRepository.GetAllEtudiants();
        }
    }
}