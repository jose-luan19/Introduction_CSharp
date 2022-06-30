using Bytebank.Modelos;
using Humanizer;
using UsesLibrary;


static void TestaListaGenerica()
{
    Lista<int> idades = new Lista<int>();
    idades.AdicionarVarios(12, 45, 2, 32, 23);

    for (int i = 0; i < idades.Tamanho; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Idade no indice {i}: {idade}");
    }

}

static void TestaListaObject()
{
    ListObject listIdade = new ListObject();
    listIdade.Adicionar(10);
    listIdade.AdicionarVarios(12, 23, 45);

    for (int i = 0; i < listIdade.Tamanho; i++)
    {
        int idade = (int)listIdade[i];
        Console.WriteLine($"Idade no indice {i}: {idade}");
    }

}

static void TestaListaConta()
{
    ListConta contas = new ListConta();

    Conta conta1 = new Conta();
    conta1.NumeroAgencia = 132;
    conta1.NumeroConta = "4165-X";

    Conta conta2 = new Conta();
    conta2.NumeroAgencia = 152;
    conta2.NumeroConta = "4635-X";

    Conta conta3 = new Conta();
    conta3.NumeroAgencia = 232;
    conta3.NumeroConta = "461325-X";

    Conta conta4 = new Conta();
    conta4.NumeroAgencia = 145;
    conta4.NumeroConta = "5541-X";

    //contas.Adicionar(conta1);
    //contas.Adicionar(conta2);
    //contas.Adicionar(conta3);
    //contas.Adicionar(conta4);

    //Conta[] itensContas = new Conta[]
    //{
    //    conta1, conta2, conta3, conta4
    //};
    //contas.AdicionarVarios(itensContas); iguais

    contas.AdicionarVarios(conta1, conta2, conta3, conta4);

    for (int i = 0; i < contas.Tamanho; i++)
    {
        //Conta itemAtual = contas.GetContaNoIndice(i);
        Conta itemAtual = contas[i];
        Console.WriteLine($"Item na posição {i} = Conta {itemAtual.NumeroConta}/{itemAtual.NumeroAgencia}");
    }

    contas.EscreverListaNaTela();

    contas.Remover(conta1);

    Console.WriteLine("Remoção");

    contas.EscreverListaNaTela();
}


static void InicializaArrayContas()
{
    Conta[] contas = new Conta[]
    {
        new Conta(),
        new Conta()
    };

    foreach (Conta conta in contas)
    {
        Console.WriteLine(conta);
    }
}


static void DateDifereece()
{
    DateTime dataPagamento = new DateTime(2022, 6, 30);
    DateTime dataCorrente = DateTime.Now;

    TimeSpan diasRestantes = dataPagamento - dataCorrente;
    TimeSpan timeForcado = TimeSpan.FromHours(2);

    Console.WriteLine("Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diasRestantes));
    Console.WriteLine(TimeSpanHumanizeExtensions.Humanize(timeForcado));
}