namespace UsesLibrary
{
    public class ListObject
    {
        private object[] _itens;

        private int _proximaPosicao;

        public int Tamanho { get => _proximaPosicao; }

        public ListObject(int capacidadeInicial = 2)
        {
            _itens = new object[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(object item)
        {
            VerificaCapacidade(_proximaPosicao + 1);

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificaCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            //Console.WriteLine("Aumentando capacidade da lista");

            //Console.WriteLine(_itens[0].ToString());

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }
            object[] novoArray = new object[novoTamanho];

            Array.Copy(_itens, novoArray, _itens.Length);
            _itens = novoArray;
            //Console.WriteLine(_itens[0].ToString());
        }

        public void Remover(object item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                object itemAtual = _itens[i];

                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public object GetIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }

        public object this[int indice]
        {
            get => GetIndice(indice);

        }

        public void AdicionarVarios(params object[] itens)
        {
            foreach (object item in itens)
            {
                Adicionar(item);
            }
        }

    }
}
