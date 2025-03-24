using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_des_Étudiants
{
    class Professeur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        //relation many to many avec matieres
        public ICollection<ProfesseursMatieres> ProfesseursMatieres { get; set; }

        //relation many to many avec classes
        public ICollection<ProfesseursClasses> ProfesseursClasses { get; set; }
    }
}
