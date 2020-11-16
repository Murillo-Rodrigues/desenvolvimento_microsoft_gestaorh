using GestaoRHWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace GestaoRHWeb.DAL
{
    public class CaixaDAO
    {
        private readonly Context _context;
        public List<Caixa> Listar() => _context.Caixas.ToList();
    }
}
