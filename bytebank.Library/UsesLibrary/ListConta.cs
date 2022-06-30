using Bytebank.Modelos;

namespace UsesLibrary
{
    public class ListConta
    {
        private Conta[] _itensContas;

        private int _proximaPosicao;

        public int Tamanho { get => _proximaPosicao; }

        public ListConta(int capacidadeInicial = 2)
        {
            _itensContas = new Conta[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(Conta item)
        {
            VerificaCapacidade(_proximaPosicao + 1);

            _itensContas[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificaCapacidade(int tamanhoNecessario)
        {
            if (_itensContas.Length >= tamanhoNecessario)
            {
                return;
            }

            //Console.WriteLine("Aumentando capacidade da lista");

            //Console.WriteLine(_itensContas[0].ToString());

            int novoTamanho = _itensContas.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }
            Conta[] novoArray = new Conta[novoTamanho];

            Array.Copy(_itensContas, novoArray, _itensContas.Length);
            _itensContas = novoArray;
            //Console.WriteLine(_itensContas[0].ToString());
        }

        public void Remover(Conta item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                Conta itemAtual = _itensContas[i];

                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itensContas[i] = _itensContas[i + 1];
            }
            _proximaPosicao--;
            _itensContas[_proximaPosicao] = null;
        }

        public void EscreverListaNaTela()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                Conta conta = _itensContas[i];
                Console.WriteLine($"Conta indice {i}: {conta.NumeroAgencia} {conta.NumeroConta}");
            }
        }

        public Conta GetContaNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itensContas[indice];
        }

        public Conta this[int indice]
        {
            get => GetContaNoIndice(indice);
            
        }

        public void AdicionarVarios(params Conta[] itens)
        {
            foreach (Conta conta in itens)
            {
                Adicionar(conta);
            }
        }

    }
}
