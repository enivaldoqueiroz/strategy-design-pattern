using StrategyExemplo.Strategy.Interfaces;

namespace StrategyExemplo.Strategy
{
    public class CompressaoGzip : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine($"\nO arquivo '{nomeArquivo}' foi compactado usando Gzip. " +
                $"Um arquivo com extensão .gzip foi criardo");
        }
    }
}
