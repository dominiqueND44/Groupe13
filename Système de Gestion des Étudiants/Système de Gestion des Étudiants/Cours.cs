using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_des_Étudiants
{
    class Cours
    {
        public int Id { get; set; }
        public string NomCours { get; set; }
        public string Description { get; set; }

        //relation many to many avec classes
        public ICollection<ClassesCours> ClassesCours { get; set; }

        //relation many to many avec matieres
        public ICollection<CoursMatieres> CoursMatieres { get; set; }
    }
}
