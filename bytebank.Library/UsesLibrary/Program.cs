using Bytebank.Modelos;
using Humanizer;

/*Conta conta1 = new Conta();
conta1.Saldo = 200;
Console.WriteLine(conta1);*/

DateTime dataPagamento = new DateTime(2022,6,30);
DateTime dataCorrente =  DateTime.Now;

TimeSpan diasRestantes = dataPagamento - dataCorrente;
TimeSpan timeForcado = TimeSpan.FromHours(2);

Console.WriteLine("Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diasRestantes));
Console.WriteLine(TimeSpanHumanizeExtensions.Humanize(timeForcado));