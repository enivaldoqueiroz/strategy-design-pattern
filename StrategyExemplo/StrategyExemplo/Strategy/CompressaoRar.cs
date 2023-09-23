using StrategyExemplo.Strategy.Interfaces;

namespace StrategyExemplo.Strategy
{
    public class CompressaoRar : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine($"\nO arquivo '{nomeArquivo}' foi compactado usando Rar. " +
                $"Um arquivo com extensão .rar foi criardo");
        }
    }
}
