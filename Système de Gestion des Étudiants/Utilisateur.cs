using System;
using System.Collections.Generic;

namespace Système_de_Gestion_des_Étudiants
{
    public class Utilisateur  // Vérifie que la classe est bien publique
    {
        public int Id { get; set; }
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }
        public string Role { get; set; }
        public string Telephone { get; set; }

        // Relation one-to-many avec OTPCode
        public ICollection<OTPCode> OTPCodes { get; set; }

        // Constructeur pour éviter les erreurs de null
        public Utilisateur()
        {
            OTPCodes = new List<OTPCode>();
        }
    }

    
}
