using bytebank;
using bytebank.Titular;

Conta conta1 = new Conta();
Cliente cliente1 = new Cliente();
cliente1.Nome = "Luan";
cliente1.CPF = "0774051879";
cliente1.Profissao = "Dev";

Cliente cliente2 = new Cliente();
cliente2.Nome = "L4";
cliente2.CPF = "7478484448";
cliente2.Profissao = "Fisio";

conta1.Titular = cliente1;
conta1.NumeroConta = "4654-Y";
conta1.NumeroAgencia = 19;
conta1.Saldo = 600.5;
conta1.Verificador = true;

Conta conta2 = new Conta();

conta2.Titular = cliente2;
conta2.NumeroConta = "2132-X";
conta2.NumeroAgencia = 15;
conta2.Saldo = 100;
conta2.Verificador = true;

Console.WriteLine(conta1);
Console.WriteLine(conta2);

conta1.Sacar(500);
Console.WriteLine(conta1);

conta1.Depositar(100.5);
Console.WriteLine(conta1);

conta1.Transferir(50, conta2);
Console.WriteLine(conta1);
Console.WriteLine(conta2);
Console.WriteLine(Conta.TotalDeContasCriadas);

