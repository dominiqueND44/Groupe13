using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_des_Étudiants
{
    class Utilisateur
    {
        public int Id { get; set; }
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }
        public string Role { get; set; }
        public string Telephone { get; set; }

        //relation one to many avec otpcodes
        public ICollection<OTPCode> OTPCodes { get; set; }
    }
}
