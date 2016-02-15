using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppWeb.ViewModels
{
    public class RoleViewModels
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DisplayName("Nom du Role")]
        public string Nom { get; set; }
    }
}