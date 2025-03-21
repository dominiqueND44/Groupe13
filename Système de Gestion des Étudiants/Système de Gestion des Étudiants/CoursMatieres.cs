using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_des_Étudiants
{
    class CoursMatieres
    {
        [Key]
        public int IdCours { get; set; }
        public Cours Cours { get; set; }
        public int IdMatiere { get; set; }
        public Matiere Matiere { get; set; }
    }
}
