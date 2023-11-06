using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AGENDAHUB.Models
{

    [Table("Profissionais")]
    public class Profissionais
    {
        [Key]
        public int ID_Profissional { get; set; }

        [Required(ErrorMessage = "O campo Nome � obrigat�rio.")]
        [StringLength(100, ErrorMessage = "O campo Nome deve conter no m�ximo 100 caracteres.")]
        [Display(Name = "Nome do Profissional")]
        public string Nome { get; set; }

        [StringLength(50, ErrorMessage = "O campo Especializa��o deve conter no m�ximo 50 caracteres.")]
        public string Cargo { get; set; }

        [StringLength(11, ErrorMessage = "O campo Telefone deve conter no m�ximo 11 caracteres.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo Email � obrigat�rio.")]
        [EmailAddress(ErrorMessage = "O campo Email deve ser um endere�o de email v�lido.")]
        public string Email { get; set; }

        public string Senha { get; set; }
        public string Login { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "O campo CPF deve conter 11 caracteres.")]
        public string CPF { get; set; }




        // Propriedade de navega��o para Usuario
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

    }
}
