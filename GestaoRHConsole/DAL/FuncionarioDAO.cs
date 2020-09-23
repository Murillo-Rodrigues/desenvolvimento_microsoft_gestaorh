using GestaoRHConsole.Models;
using System.Collections.Generic;
using System.Linq;

namespace GestaoRHConsole.DAL
{
    class FuncionarioDAO
    {
        private static Context _context = SingletonContext.GetInstance();

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

        public static List<Funcionario> Listar() => _context.Funcionarios.ToList();

        public static Funcionario BuscarPorMatricula(string matricula) => _context.Funcionarios.FirstOrDefault(x => x.Matricula == matricula);

        public static void AlterarFuncionario(Funcionario funcionario)
        {
            _context.Funcionarios.Update(funcionario);
            _context.SaveChanges();
        }

        public static void RemoverFuncionario(Funcionario funcionario)
        {
            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();
        }
    }
}
