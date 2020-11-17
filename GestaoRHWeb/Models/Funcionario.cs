using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoRHWeb.Models
{
    [Table("Funcionarios")]
    public class Funcionario : BaseModel
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(7, ErrorMessage = "Necessário matrícula com mínimo 7 caracteres!")]
        [MaxLength(7)]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(11, ErrorMessage = "Necessário CPF conter 11 dígitos!")]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"{Matricula}";
        }
    }
}
