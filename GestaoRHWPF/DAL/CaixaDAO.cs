using GestaoRHWPF.Models;
using System.Collections.Generic;
using System.Linq;

namespace GestaoRHWPF.DAL
{
    class CaixaDAO
    {
        private static Context _context = new Context();

        public static Caixa BuscarPorNumeroCaixa(string numeroCaixa) =>
            _context.Caixas.FirstOrDefault(x => x.NumeroCaixa == numeroCaixa);

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

        public static List<Caixa> Listar() => _context.Caixas.ToList();
    }
}
