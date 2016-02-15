using ClassLibrary;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppWeb.ViewModels
{
	public class EmployeViewModel
	{
        [Key]
        [DisplayName("Id")]
        public int Employeid { get; set; }

        [Required(ErrorMessage = "Rempliez le champ Nom")]
        [MaxLength(30, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(3, ErrorMessage = "Minimun {0} caractères")]
        [DisplayName("Nom")]
        public string nomEmploye { get; set; }

        [DisplayName("Prénom")]
        [Required(ErrorMessage = "Rempliez le champ Prénom")]
        [MaxLength(30, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(3, ErrorMessage = "Minimun {0} caractères")]
        public string prenomEmploye { get; set; }

        [DisplayName("Téléphone")]
        [Required(ErrorMessage = "Rempliez le champ Téléphone")]
        [MaxLength(13, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(8, ErrorMessage = "Minimun {0} caractères")]
        public string telEmploye { get; set; }

        [Required(ErrorMessage = "Rempliez le champ E-mail")]
        [EmailAddress(ErrorMessage = "Rempliez un E-mail valide")]
        [DisplayName("E-mail")]
        public string emailEmploye { get; set; }

        [DisplayName("Adresse")]
        [Required(ErrorMessage = "Rempliez le champ Adresse")]
        [MaxLength(100, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(5, ErrorMessage = "Minimun {0} caractères")]
        public string adresseEmploye { get; set; }
        
        [DisplayName("Type")]
        [Required(ErrorMessage = "Rempliez le champ Type")]
        public int typeEmployeid { get; set; }

        public virtual TypeEmploye TypeEmploye { get; set; }

    }
}