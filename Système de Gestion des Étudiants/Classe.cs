using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_des_Étudiants
{
    class Classe
    {
        public int Id { get; set; }
        public string NomClasse { get; set; }

        //relation one to many avec etudiant
        public ICollection<Etudiant> Etudiants { get; set; }

        //relation many to many avec cours
        public ICollection<ClassesCours> ClassesCours { get; set; }

        //relation many to many avec professeurs
        public ICollection<ProfesseursClasses> ProfesseursClasses { get; set; }
    }
}
