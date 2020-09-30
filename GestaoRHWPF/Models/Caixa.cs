using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoRHWPF.Models
{
    [Table("Caixas")]
    class Caixa : BaseModel
    {

        public string NumeroCaixa { get; set; }
        public string PosicaoCorredor { get; set; }
        public string PosicaoEstante { get; set; }
        public string PosicaoAltura { get; set; }

    }
}
