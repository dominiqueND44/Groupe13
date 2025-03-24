using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_des_Étudiants
{
    class Matiere
    {
        public int Id { get; set; }
        public string NomMatiere { get; set; }

        //relation many to many avec cours
        public ICollection<CoursMatieres> CoursMatieres { get; set; }

        //relation many to many avec professeurs
        public ICollection<ProfesseursMatieres> ProfesseursMatieres { get; set; }

        //relation one to many avec notes
        public ICollection<Note> Notes { get; set; }

    }
}
