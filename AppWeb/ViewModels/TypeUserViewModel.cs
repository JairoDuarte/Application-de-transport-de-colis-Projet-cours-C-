
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppWeb.ViewModels
{
    public class NatureColisViewModel
    {
        [Key]
        [DisplayName("Id")]
        public int NatureColisid { get; set; }

        [Required(ErrorMessage = "Rempliez le champ Nom")]
        [MaxLength(30, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(5, ErrorMessage = "Minimun {0} caractères")]
        [DisplayName("Nom")]
        public string NomNatureColis { get; set; }

    }
    public class VoieTransmissionViewModel
    {
        [Key]
        [DisplayName("Id")]
        public int VoieTransmissionid { get; set; }

        [Required(ErrorMessage = "Rempliez le champ Nom")]
        [MaxLength(30, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(5, ErrorMessage = "Minimun {0} caractères")]
        [DisplayName("Nom")]
        public string VoieTransmissionNom { get; set; }

    }
    public class UserRoleViewModels
    {
        [Required(ErrorMessage = "Rempliez le champ UserID")]
        [DisplayName("Utilisateur Id")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Rempliez le champ RoleId")]
        [DisplayName("Role ID")]
        public string Roleid { get; set; }
    }
    public class TypeColisViewModel
    {
        [Key]
        [DisplayName("Id")]

        public int TypeColisid { get; set; }
        [Required(ErrorMessage = "Rempliez le champ Nom")]
        [MaxLength(30, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(5, ErrorMessage = "Minimun {0} caractères")]
        [DisplayName("Nom")]
        public string nomTypeColis { get; set; }

    }
    public class TypeEmployeViewModel
    {
        [Key]
        [DisplayName("Id")]
        public int TypeEmployeid { get; set; }

        [Required(ErrorMessage = "Rempliez le champ Nom")]
        [MaxLength(30, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(5, ErrorMessage = "Minimun {0} caractères")]
        [DisplayName("Nom")]
        public string nomTypeEmploye { get; set; }

    }
    public class VilleViewModel
    {
        [Key]
        [DisplayName("Id")]
        public int Villeid { get; set; }

        [Required(ErrorMessage = "Rempliez le champ Nom")]
        [MaxLength(30, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(3, ErrorMessage = "Minimun {0} caractères")]
        [DisplayName("Nom")]
        public string NomVille { get; set; }
    }
}