using System;

namespace ClassLibrary
{
    public class Employe
    {
        public int Employeid { get; set; }
        public string nomEmploye { get; set; }
        public string adresseEmploye { get; set; }
        public int telEmploye { get; set; }
        public string emailEmploye { get; set; }
        public string prenomEmploye { get; set; }
        
        public  int typeEmployeId { get; set; }

        public virtual TypeEmploye TypeEmploye { get; set; }
    }
}
