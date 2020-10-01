using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoRHWPF.Models
{
    [Table("ItensSolicitacao")]
    class ItemSolicitacao : BaseModel
    {
        public ItemSolicitacao()
        {
            Prontuario = new Prontuario();
        }

        public Prontuario Prontuario { get; set; }

    }
}
