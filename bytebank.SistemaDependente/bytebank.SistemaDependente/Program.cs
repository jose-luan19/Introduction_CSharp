
using Bytebank.Modelos;
using Bytebank.Modelos.Titular;

Cliente cliente1 = new Cliente();
cliente1.Nome = "Luan";
cliente1.CPF = "123456";
cliente1.Profissao = "Quase Dev";

Conta conta1 = new Conta();
conta1.Titular = cliente1;
Console.WriteLine(conta1);