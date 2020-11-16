using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoRHWeb.Models
{
    [Table("Funcionários")]
    public class Funcionario : BaseModel
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(7, ErrorMessage = "Necessário matrícula com mínimo 7 caracteres!")]
        [MaxLength(7)]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }

    }
}
