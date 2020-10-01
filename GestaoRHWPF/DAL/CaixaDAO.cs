using GestaoRHWPF.Models;
using System.Collections.Generic;
using System.Linq;

namespace GestaoRHWPF.DAL
{
    class CaixaDAO
    {
        private static Context _context = SingletonContext.GetInstance();

        public static Caixa BuscarPorNumeroCaixa(string numeroCaixa) =>
            _context.Caixas.FirstOrDefault(x => x.NumeroCaixa == numeroCaixa);
        public static Caixa BuscarPorId(int id) =>
            _context.Caixas.FirstOrDefault(x => x.Id == id);
        public static Prontuario BuscarPorIdCaixaNoProntuario(int id) =>
           _context.Prontuarios.FirstOrDefault(x => x.Caixa.Id == id);

        public static bool Cadastrar(Caixa caixa)
        {
            if (BuscarPorNumeroCaixa(caixa.NumeroCaixa) == null)
            {
                _context.Caixas.Add(caixa);
                _context.SaveChanges();

                return true;
            }
            return false;
        }

        public static bool Remover(Caixa caixa)
        {
            if (BuscarPorIdCaixaNoProntuario(caixa.Id) == null)
            {
                _context.Caixas.Remove(caixa);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<Caixa> Listar() => _context.Caixas.ToList();
    }
}
