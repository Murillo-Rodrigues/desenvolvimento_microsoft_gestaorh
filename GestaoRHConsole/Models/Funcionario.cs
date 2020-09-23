using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoRHConsole.Models
{
    [Table("Funcionários")]
    class Funcionario
    {
        public Funcionario(string matricula, string cpf, string nome)
        {
            Matricula = matricula;
            Cpf = cpf;
            Nome = nome;
        }

        public Funcionario() => CriadoEm = DateTime.Now;

        [Key]
        public int FuncionarioId { get; set; }
        public string Matricula { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() => $"ID: {FuncionarioId} | Matricula: {Matricula} | Cpf: {Cpf} |" +
                                            $" Nome: {Nome} | Criado em: {CriadoEm}\n\n";

    }
}
