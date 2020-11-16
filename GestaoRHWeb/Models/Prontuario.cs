using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoRHWeb.Models
{
    [Table("Prontuarios")]
    public class Prontuario : BaseModel
    {
        public Prontuario()
        {
            Funcionario = new Funcionario();
            Caixa = new Caixa();
        }

        public Funcionario Funcionario { get; set; }
        public Caixa Caixa { get; set; }

    }
}
