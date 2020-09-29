using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoRHWPF.Models
{

    [Table("Funcionários")]
    class Funcionario : BaseModel
    {
        public string Matricula { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
    }
}
