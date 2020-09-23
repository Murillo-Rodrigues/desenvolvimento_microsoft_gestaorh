using System;

namespace GestaoRHConsole.Models
{
    class Prontuario
    {
        public Prontuario(string matricula, string cpf, string nome)
        {
            Matricula = matricula;
            Cpf = cpf;
            Nome = nome;
        }

        public Prontuario() => CriadoEm = DateTime.Now;

        public string Matricula { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() => $"";

    }
}
