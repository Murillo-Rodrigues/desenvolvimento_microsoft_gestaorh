using GestaoRHWPF.Models;
using System.Collections.Generic;
using System.Linq;

namespace GestaoRHWPF.DAL
{
    class CaixaDAO
    {
        private static Context _context = SingletonContext.GetInstance();

        /**
         * Buscas no banco para validar um cadastro de uma caixa
         */
        public static Caixa BuscarPorNumeroCaixa(string numeroCaixa) =>
            _context.Caixas.FirstOrDefault(x => x.NumeroCaixa == numeroCaixa);

        public static Caixa BuscarPorCustodia(string custodia) =>
            _context.Caixas.FirstOrDefault(x => x.Custodia == custodia);

        /**
         */
        public static Caixa BuscarPorId(int id) =>
            _context.Caixas.Find(id);
        public static Prontuario BuscarPorIdCaixaNoProntuario(int id) =>
           _context.Prontuarios.FirstOrDefault(x => x.Caixa.Id == id);

        public static void Cadastrar(Caixa caixa)
        {
            _context.Caixas.Add(caixa);
            _context.SaveChanges();
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
