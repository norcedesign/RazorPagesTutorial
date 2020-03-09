using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesTutorial.Models
{
   public class Etudiant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public Dept? Departement { get; set; }
    }
}
