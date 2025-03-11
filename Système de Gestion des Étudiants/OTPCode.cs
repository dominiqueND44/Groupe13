using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_des_Étudiants
{
    public class OTPCode
    {
        public int Id { get; set; }
        public int IdUtilisateur { get; set; }
        public string Code { get; set; }
        public DateTime DateExpiration { get; set; }

        //navigation property
        public Utilisateur Utilisateur { get; set; }
    }
}
