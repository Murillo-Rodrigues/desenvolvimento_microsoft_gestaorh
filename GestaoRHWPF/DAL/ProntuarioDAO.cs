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

        public static Prontuario BuscarPorIdFuncionarioP(int id) =>
            _context.Prontuarios.Include(x => x.Funcionario).Include(x => x.Caixa).FirstOrDefault(x => x.Funcionario.Id == id);

        public static Prontuario BuscarPorIdCaixaP(int id) =>
           _context.Prontuarios.FirstOrDefault(x => x.Caixa.Id == id);


        public static void Cadastrar(Prontuario prontuario)
        {
            _context.Prontuarios.Add(prontuario);
            _context.SaveChanges();

        }

        public static void Remover(Prontuario prontuario)
        {
            _context.Prontuarios.Remove(prontuario);
            _context.SaveChanges();
        }

        public static List<Prontuario> Listar() => _context.Prontuarios.ToList();
    }
}
