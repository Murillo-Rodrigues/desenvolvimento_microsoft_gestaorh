using GestaoRHWPF.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GestaoRHWPF.DAL
{
    class ProntuarioDAO
    {
        private static Context _context = SingletonContext.GetInstance();

        public static Prontuario BuscarPorMatriculaP(string matricula) =>
            _context.Prontuarios.Include(x => x.Funcionario).Include(x => x.Caixa).FirstOrDefault(x => x.Funcionario.Matricula == matricula);
        public static Prontuario BuscarPorIdP(int id) =>
           _context.Prontuarios.Include(x => x.Funcionario).Include(x => x.Caixa).FirstOrDefault(x => x.Funcionario.Id == id);


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
