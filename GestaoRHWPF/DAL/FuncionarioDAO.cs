using GestaoRHWPF.Models;
using System.Collections.Generic;
using System.Linq;

namespace GestaoRHWPF.DAL
{
    class FuncionarioDAO
    {

        private static Context _context = SingletonContext.GetInstance();

        public static Funcionario BuscarPorMatricula(string matricula) =>
            _context.Funcionarios.FirstOrDefault(x => x.Matricula == matricula);
        public static Funcionario BuscarPorId(int id) =>
            _context.Funcionarios.FirstOrDefault(x => x.Id == id);

        public static bool Cadastrar(Funcionario funcionario)
        {
            if (BuscarPorMatricula(funcionario.Matricula) == null)
            {
                _context.Funcionarios.Add(funcionario);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public static void Remover(Funcionario funcionario)
        {
            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();
        }

        public static List<Funcionario> Listar() => _context.Funcionarios.ToList();
    }
}
