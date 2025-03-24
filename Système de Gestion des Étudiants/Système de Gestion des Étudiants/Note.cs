using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_des_Étudiants
{
    class Note
    {
        public int Id { get; set; }
        public int IdEtudiant { get; set; }
        public int IdMatiere { get; set; }
        public string Notes { get; set; }

        //navigation property
        public Etudiant Etudiant { get; set; }
        public Matiere Matiere { get; set; }
    }
}
