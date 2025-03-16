using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_des_Étudiants
{
    class ProfesseursMatieres
    {
        [Key]
        public int IdProfesseur { get; set; }
        public Professeur Professeur { get; set; }
        public int IdMatiere { get; set; }
        public Matiere Matiere { get; set; }
    }
}
