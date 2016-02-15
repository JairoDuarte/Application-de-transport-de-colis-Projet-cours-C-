
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppWeb.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        [DisplayName("Code Client")]
        public int Clientid { get; set; }

        [DisplayName("Nom")]
        [Required(ErrorMessage = "Rempliez le champ Nom")]
        [MaxLength(100, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(5, ErrorMessage = "Minimun {0} caractères")]
        public string nomClient { get; set; }

        [DisplayName("Prénom")]
        [Required(ErrorMessage = "Rempliez le champ Prénom")]
        [MaxLength(100, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(5, ErrorMessage = "Minimun {0} caractères")]
        public string prenomClient { get; set; }

        [DisplayName("Téléphone")]
        [Required(ErrorMessage = "Rempliez le champ Téléphone")]
        [MaxLength(13, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(8, ErrorMessage = "Minimun {0} caractères")]
        public string telClient { get; set; }

        [Required(ErrorMessage = "Rempliez le champ E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Rempliez un E-mail valide")]
        [DisplayName("E-mail")]
        public string emailClient { get; set; }

        [DisplayName("Fax")]
        [MaxLength(100, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(5, ErrorMessage = "Minimun {0} caractères")]
        public string faxClient { get; set; }

        [DisplayName("Adresse")]
        [MaxLength(100, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(5, ErrorMessage = "Minimun {0} caractères")]
        public string adresseClient { get; set; }
        
        
    }
}