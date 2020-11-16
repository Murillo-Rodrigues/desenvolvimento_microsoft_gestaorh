using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoRHWeb.Models
{
    [Table("Caixas")]
    public class Caixa : BaseModel
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string NumeroCaixa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Custodia { get; set; }

    }
}
