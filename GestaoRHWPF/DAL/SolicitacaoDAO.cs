using GestaoRHWPF.Models;
using System.Collections.Generic;
using System.Linq;

namespace GestaoRHWPF.DAL
{
    class SolicitacaoDAO
    {
        private static Context _context = SingletonContext.GetInstance();

        public static Solicitacao BuscarPorIdS(int id) =>
            _context.Solicitacoes.FirstOrDefault(x => x.Funcionario.Id == id);

        public static Solicitacao BuscarPorIdSolicitacao(int id) =>
            _context.Solicitacoes.FirstOrDefault(x => x.Id == id);


        public static bool Cadastrar(Solicitacao solicitacao)
        {
            if (BuscarPorIdS(solicitacao.Funcionario.Id) == null)
            {
                _context.Solicitacoes.Add(solicitacao);
                _context.SaveChanges();
                return true;
            }
            return false;
        }


        public static List<Solicitacao> Listar() => _context.Solicitacoes.ToList();

    }
}
