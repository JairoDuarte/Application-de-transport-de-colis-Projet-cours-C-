
using ClassLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AppWeb.ViewModels
{
    [Authorize(Roles ="Admin")]
    public class UserViewModel
    {   
        [Key]
        [DisplayName("Id user")]
        public string Userid { get; set; }

        [DisplayName("Mot de passe")]
        [Required(ErrorMessage = "Rempliez le champ")]
        [MaxLength(100, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(5, ErrorMessage = "Minimun {0} caractères")]
        public string motpasseUser { get; set; }

        [DisplayName("Nom d'user")]
        [Required(ErrorMessage = "Rempliez le champ")]
        [MaxLength(100, ErrorMessage = "Maximum {0} caractères")]
        [MinLength(5, ErrorMessage = "Minimun {0} caractères")]
        public string nomUser { get; set; }

        [Required(ErrorMessage = "Rempliez le champ E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Rempliez un E-mail valide")]
        [DisplayName("E-mail")]
        public string emailUser { get; set; }

      public virtual  List<RoleViewModels> Roles { get; set; }
    }
}