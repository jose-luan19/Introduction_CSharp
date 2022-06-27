
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitarios;

Designer luanDesigner = new Designer(2000);

luanDesigner.Nome = "Luan";
luanDesigner.Cpf = "054515621";

Diretor diretoraL4 = new Diretor(5000);
diretoraL4.Nome = "Osso de vidro";
diretoraL4.Cpf = "1465467";
diretoraL4.Senha = "1960";

GerenteDeContas gerenteDeContas = new GerenteDeContas(1500);
gerenteDeContas.Cpf = "46511";
gerenteDeContas.Nome = "Sas";
gerenteDeContas.Senha = "123";

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(luanDesigner);
gerenciador.Registrar(diretoraL4);
gerenciador.Registrar(gerenteDeContas);

Parceiro parceiro = new Parceiro();
parceiro.Senha = "789";


Console.WriteLine(luanDesigner);
Console.WriteLine(luanDesigner.GetBonificacao());
Console.WriteLine(diretoraL4);
Console.WriteLine(diretoraL4.GetBonificacao());
Console.WriteLine(gerenteDeContas);
Console.WriteLine(gerenteDeContas.GetBonificacao());
Console.WriteLine(gerenciador.TotalBonificacao);
Console.WriteLine(Funcionario.TotalFuncionarios);

luanDesigner.AumentarSalario();
Console.WriteLine(luanDesigner);
Console.WriteLine(luanDesigner.GetBonificacao());
diretoraL4.AumentarSalario();
Console.WriteLine(diretoraL4);
Console.WriteLine(diretoraL4.GetBonificacao());

SistemaInterno sistemaInterno = new SistemaInterno();
sistemaInterno.Logar(diretoraL4, "1960");
sistemaInterno.Logar(gerenteDeContas, "789");
sistemaInterno.Logar(parceiro, "789");
