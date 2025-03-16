using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_des_Étudiants
{
    class Etudiant
    {
       public int Id { get; set; }
       public string Matricule { get; set; }
       public string Nom { get; set; }
       public string Prenom { get; set; }
       public DateTime DateNaissance { get; set; }
       public string sexe { get; set; }
       public string Adresse { get; set; }
       public string Telephone { get; set; }
       public string Email { get; set; }

        //foreign key
       public int IdClasse { get; set; }
        //navigation property
        public Classe Classe { get; set; }

        //relation one to many avec notes
        public ICollection<Note> Notes { get; set; }


    }
}
