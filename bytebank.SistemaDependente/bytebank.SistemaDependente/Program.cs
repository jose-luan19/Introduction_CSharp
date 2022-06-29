using System.Text.RegularExpressions;
using bytebank.SistemaDependente;

string url = "pagina?moedaOrigem=real&moedaDestino=dolar&valor=1500";
Console.WriteLine(url.Contains('?'));
ExtratorArgURL extrator = new ExtratorArgURL(url);

string valor = extrator.GetValor("MoedaDestino");

Console.WriteLine(valor);

string padrão= "[0-9]{4,5}-?[0-9]{4}";
string textFree = "Meu número de telefone é 97894-4654";
Match resuldaMatch = Regex.Match(textFree, padrão);

Console.WriteLine(resuldaMatch.Value);