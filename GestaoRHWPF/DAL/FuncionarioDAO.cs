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

        public static Prontuario BuscarPorIdFuncionarioNoProntuario(int id) =>
             _context.Prontuarios.FirstOrDefault(x => x.Funcionario.Id == id);

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

        public static bool Remover(Funcionario funcionario)
        {
            if (BuscarPorIdFuncionarioNoProntuario(funcionario.Id) == null)
            {
                _context.Funcionarios.Remove(funcionario);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool Alterar(Funcionario funcionario)
        {
            if (BuscarPorIdFuncionarioNoProntuario(funcionario.Id) == null)
            {
                _context.Funcionarios.Update(funcionario);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<Funcionario> Listar() => _context.Funcionarios.ToList();
    }
}
