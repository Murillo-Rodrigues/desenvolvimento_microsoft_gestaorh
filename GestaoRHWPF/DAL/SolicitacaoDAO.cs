using GestaoRHWPF.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GestaoRHWPF.DAL
{
    class SolicitacaoDAO
    {
        private static Context _context = SingletonContext.GetInstance();

        public static Prontuario BuscarPorIdS(int id) =>
            _context.Prontuarios.Include(x => x.Funcionario).Include(x => x.Caixa).FirstOrDefault(x => x.Funcionario.Id == id);
        public static Prontuario BuscarPorIdSolicitacao(int id) =>
            _context.Prontuarios.FirstOrDefault(x => x.Id == id);


        public static bool Cadastrar(Solicitacao solicitacao)
        {
            if (BuscarPorIdSolicitacao(solicitacao.Id) == null)
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
