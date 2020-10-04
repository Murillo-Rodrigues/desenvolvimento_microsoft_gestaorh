using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoRHWPF.Models
{
    [Table("Caixas")]
    class Caixa : BaseModel
    {

        public string NumeroCaixa { get; set; }
        public string Custodia { get; set; }

        public override string ToString()
        {
            return $"{Custodia}";
        }

    }
}
