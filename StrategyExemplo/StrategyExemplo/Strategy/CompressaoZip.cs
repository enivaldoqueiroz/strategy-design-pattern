using StrategyExemplo.Strategy.Interfaces;

namespace StrategyExemplo.Strategy
{
    public class CompressaoZip : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine($"\nO arquivo '{nomeArquivo}' foi compactado usando Zip. " +
                $"Um arquivo com extensão .zip foi criardo");
        }
    }
}
