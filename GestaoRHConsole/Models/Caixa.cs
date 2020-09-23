using System;

namespace GestaoRHConsole.Models
{
    class Caixa
    {
        public Caixa(string numerocaixa, string posicaocorredor, string posicaocomprimento, string posicaoaltura)
        {
            NumeroCaixa = numerocaixa;
            PosicaoCorredor = posicaocorredor;
            PosicaoComprimento = posicaocomprimento;
            PosicaoAltura = posicaoaltura;
        }
        public Caixa() => CriadoEm = DateTime.Now;

        public string NumeroCaixa { get; set; }
        public string PosicaoCorredor { get; set; }
        public string PosicaoComprimento { get; set; }
        public string PosicaoAltura { get; set; }
        public DateTime CriadoEm { get; set; }


        public override string ToString() => $"NumeroCaixa: {NumeroCaixa} | Corredor: {PosicaoCorredor} |" +
                                            $" Comprimento: {PosicaoComprimento}| Altura: {PosicaoAltura} |" +
                                            $" Criado em: {CriadoEm}\n\n";
    }
}
