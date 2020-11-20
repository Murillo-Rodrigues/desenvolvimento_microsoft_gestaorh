using GestaoRHWeb.Models;

namespace GestaoRHWeb.DAL
{
    public class ItemSolicitacaoDAO
    {
        private readonly Context _context;

        public ItemSolicitacaoDAO(Context context) => _context = context;
        public void Cadastrar(ItemSolicitacao item)
        {
            _context.ItensSolicitacao.Add(item);
            _context.SaveChanges();
        }
    }
}
