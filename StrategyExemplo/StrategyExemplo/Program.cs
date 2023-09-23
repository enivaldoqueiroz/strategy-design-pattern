using StrategyExemplo.Strategy;

Console.WriteLine("## Padrão Strategy ##\n");

CompressaoContext ctx = new CompressaoContext(new CompressaoRar());

Console.WriteLine("Informe o nome do arquivo a comprimir");
var nomeArquivo = Console.ReadLine();

Console.WriteLine("\n Informe o tipo de compressão a ser usada");
Console.WriteLine("1 - Rar(Padrão) | 2 - Zip | 3 - Gzip\n");
string readLine  = Console.ReadLine();
if (!string.IsNullOrEmpty(readLine))
{
	var opcao = Convert.ToInt32(readLine);

	switch (opcao)
	{
		case 2:
			ctx.DefineStrategy(new CompressaoZip());
			break;
		case 3:
			ctx.DefineStrategy(new CompressaoGzip());
			break;
		default:
			ctx.DefineStrategy(new CompressaoRar());
			break;
	}
}

ctx.CriarArquivoCompactado(nomeArquivo);

Console.Read();
