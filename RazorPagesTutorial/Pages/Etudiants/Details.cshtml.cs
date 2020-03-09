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
    public class DetailsModel : PageModel
    {
        public IEtudiantRepository EtudiantRepository { get; set; }
        public Etudiant Etudiant { get; set; }
        public DetailsModel(IEtudiantRepository EtudiantRepository)
        {
           this.EtudiantRepository = EtudiantRepository;
        }
        public void OnGet(int Id=1)
        {
            Etudiant = EtudiantRepository.GetEtudiant(Id); //GetAllEtudiants().Where(e => e.Id == Id).FirstOrDefault();
        }
    }
}