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
    public class EditModel : PageModel
    {
        public IEtudiantRepository EtudiantRepository { get; set; }
        [BindProperty]
        public Etudiant Etudiant { get; set; }
        public EditModel(IEtudiantRepository EtudiantRepository)
        {
            this.EtudiantRepository = EtudiantRepository;
        }
        public void OnGet(int Id)
        {
            Etudiant = EtudiantRepository.GetEtudiant(Id); //GetAllEtudiants().Where(e => e.Id == Id).FirstOrDefault();
        }

        public IActionResult OnPost(Etudiant etudiant)
        {
          Etudiant =  EtudiantRepository.Update(etudiant);
            return RedirectToPage("/Index");
        }
    }
}