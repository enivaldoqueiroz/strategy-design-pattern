using StrategyExemplo.Strategy.Interfaces;

namespace StrategyExemplo.Strategy
{
    //Contexto
    public class CompressaoContext
    {
        private ICompressao _icompressao;

        public CompressaoContext(ICompressao icompressao)
        {
            _icompressao = icompressao;
        }

        public CompressaoContext() { }

        public void DefineStrategy(ICompressao icompressao)
        {
            _icompressao = icompressao;
        }

        public void CriarArquivoCompactado(string nomeArquivo)
        {
            _icompressao.ComprimirArquivo(nomeArquivo);
        }
    }
}
