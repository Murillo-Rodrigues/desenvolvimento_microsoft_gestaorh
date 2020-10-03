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
        public static Solicitacao BuscarPorIdSolicitacao(int id) =>
            _context.Solicitacoes.FirstOrDefault(x => x.Id == id);


        public static void Cadastrar(Solicitacao solicitacao)
        {
            _context.Solicitacoes.Add(solicitacao);
            _context.SaveChanges();
        }

        public static List<Solicitacao> Listar() => _context.Solicitacoes.ToList();

    }
}
