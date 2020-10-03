using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Documents;

namespace GestaoRHWPF.Models
{
    [Table("Prontuarios")]
    class Prontuario : BaseModel
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
