using System.ComponentModel.DataAnnotations;

namespace aula2.ViewModels.Conta.Login
{
    public class LoginVM
    {
        [Required(ErrorMessage = "O {0} é obrigatorio")]
        [StringLength(40, ErrorMessage = "O Limite do {0} é de {1} caracteres ")]
        [RegularExpression(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", ErrorMessage = "Email Inválido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "O {0} é obrigatorio")]
        [StringLength(40, ErrorMessage = "O Limite da {0} é de {1} caracteres ")]
        public string Senha { get; set; }


        public bool PermanecerLogado { get; set; }

        public string ReturnURL { get; set; }
    }
}