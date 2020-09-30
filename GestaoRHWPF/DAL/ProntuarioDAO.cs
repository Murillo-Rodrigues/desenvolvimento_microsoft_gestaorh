using GestaoRHWPF.Models;
using System.Collections.Generic;
using System.Linq;

namespace GestaoRHWPF.DAL
{
    class ProntuarioDAO
    {
        private static Context _context = new Context();

        public static Prontuario BuscarPorMatriculaP(string matricula) =>
            _context.Prontuarios.FirstOrDefault(x => x.Funcionario.Matricula == matricula);

        public static bool Cadastrar(Prontuario prontuario)
        {
            if (BuscarPorMatriculaP(prontuario.Funcionario.Matricula) == null)
            {
                _context.Prontuarios.Add(prontuario);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public static void Remover(Prontuario prontuario)
        {
            _context.Prontuarios.Remove(prontuario);
            _context.SaveChanges();
        }

        public static List<Prontuario> Listar() => _context.Prontuarios.ToList();
    }
}
