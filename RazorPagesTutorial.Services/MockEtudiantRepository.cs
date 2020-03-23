using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RazorPagesTutorial.Models;

namespace RazorPagesTutorial.Services
{
    public class MockEtudiantRepository : IEtudiantRepository
    {
        private List<Etudiant> ListEtudiants;
        public MockEtudiantRepository()
        {
            ListEtudiants = new List<Etudiant>()
            {
                new Etudiant (){Id=1, Nom="Mike Cohen", Departement= Dept.Finances, Email="Cohen.mhn.com",PhotoPath="cohen.jpg"},
                 new Etudiant (){Id=2, Nom="Jean Michel", Departement= Dept.Education, Email="michel.mhn.com",PhotoPath="michel.jpg"},
                  new Etudiant (){Id=3, Nom="Marie André", Departement= Dept.Informatique, Email="marie.mhn.com",PhotoPath="marie.jpg"},
                   new Etudiant (){Id=4, Nom="John Doe", Departement= Dept.Finances, Email="doe.mhn.com",PhotoPath="doe.jpg"}

            };
        }
        IEnumerable<Etudiant> IEtudiantRepository.GetAllEtudiants()
        {
            return ListEtudiants;
        }

        Etudiant IEtudiantRepository.GetEtudiant(int id)
        {
           return ListEtudiants.Where(e => e.Id == id).FirstOrDefault();
        }

        Etudiant IEtudiantRepository.Update(Etudiant etudiantModif)
        {
            Etudiant etudiant = ListEtudiants.FirstOrDefault(e => e.Id == etudiantModif.Id);

            if(etudiant != null)
            {
                etudiant.Nom = etudiantModif.Nom;
                etudiant.Email = etudiantModif.Email;
                etudiant.Departement = etudiantModif.Departement;
                etudiant.PhotoPath = etudiantModif.PhotoPath;
            }

            return etudiant;
        }
    }
}
