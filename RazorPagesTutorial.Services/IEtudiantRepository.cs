using RazorPagesTutorial.Models;
using System;
using System.Collections.Generic;

namespace RazorPagesTutorial.Services
{
    public interface IEtudiantRepository
    {
        IEnumerable<Etudiant> GetAllEtudiants();
        Etudiant GetEtudiant(int id);

        Etudiant Update(Etudiant etudiant);
    }
}
