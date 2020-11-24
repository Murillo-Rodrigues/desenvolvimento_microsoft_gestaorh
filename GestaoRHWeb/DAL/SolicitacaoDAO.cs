using GestaoRHWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GestaoRHWeb.DAL
{
    public class SolicitacaoDAO
    {
        private readonly Context _context;

        public SolicitacaoDAO(Context context) => _context = context;

        public Solicitacao BuscarPorIdS(int id) =>
            _context.Solicitacoes.FirstOrDefault(x => x.Funcionario.Id == id);

        public Solicitacao BuscarPorIdSolicitacao(int id) =>
            _context.Solicitacoes.FirstOrDefault(x => x.Id == id);

        public bool Cadastrar(Solicitacao solicitacao)
        {
            if (BuscarPorIdS(solicitacao.Funcionario.Id) == null)
            {
                _context.Solicitacoes.Add(solicitacao);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Solicitacao> Listar() => _context.Solicitacoes.Include(x => x.Funcionario).Include(x => x.Caixa).ToList();
    }
}
