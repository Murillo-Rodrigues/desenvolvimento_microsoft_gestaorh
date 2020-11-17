using GestaoRHWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GestaoRHWeb.DAL
{
    public class ProntuarioDAO
    {
        private readonly Context _context;

        public ProntuarioDAO(Context context) => _context = context;

        public Prontuario BuscarPorMatriculaECaixaP(string matricula) =>
           _context.Prontuarios.Include(x => x.Funcionario).Include(x => x.Caixa).FirstOrDefault(x => x.Funcionario.Matricula == matricula);

        public Prontuario BuscarPorMatriculaP(string matricula) =>
           _context.Prontuarios.FirstOrDefault(x => x.Funcionario.Matricula == matricula);

        public Prontuario BuscarPorNumeroCaixaP(string numeroCaixa) =>
            _context.Prontuarios.FirstOrDefault(x => x.Caixa.NumeroCaixa == numeroCaixa);


        public bool Cadastrar(Prontuario prontuario)
        {
            if (BuscarPorMatriculaECaixaP(prontuario.Funcionario.Matricula) == null)
            {
                _context.Prontuarios.Add(prontuario);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
