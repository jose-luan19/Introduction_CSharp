/*using Newtonsoft.Json;*/
using Bytebank.Modelos.Titular;

namespace Bytebank.Modelos
{
    /// <summary>
    /// Define uma conta do banco Bytebank.
    /// </summary>
    public class Conta : IComparable
    {
        //Atributos sem validação podem ser public e criados em tempo de execução
        public Cliente Titular { get; set; }

        private string _numero_conta;
        public string NumeroConta
        {
            get => _numero_conta;
            set
            {
                if (value != null)
                {
                    _numero_conta = value;
                }
            }
        }

        private int _numero_agencia;

        public int NumeroAgencia
        {
            get => _numero_agencia;
            set
            {
                if (value > 0)
                {
                    _numero_agencia = value;
                }
            }
        }
        public bool Verificador { get; set; }

        //Atributos que não devem ser acessados diretamente tem que ser private e criar metodo para get e set
        private double _saldo;

        public double Saldo
        {
            get => _saldo;
            set
            {
                if (value > 0)
                {
                    _saldo = value;
                }
            }
        }

        public static int TotalDeContasCriadas { get; set; }

        public Conta()
        {
            TotalDeContasCriadas++;
        }

        public Conta(int agencia, string conta, double saldo)
        {
            NumeroAgencia = agencia;
            NumeroConta = conta;
            Saldo = saldo;
        }


        /* public override string ToString()
         {
             return JsonConvert.SerializeObject(this);
         }*/

        public override string ToString()
        {
            return $"Titular: [ {Titular} ], " +
                   $"NumeroConta: {NumeroConta}, " +
                   $"NumeroAgencia: {NumeroAgencia}, " +
                   $"Verificador: {Verificador}, " +
                   $"Saldo: {Saldo}";
        }


        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>.
        /// </summary>
        /// <param name="valor"> Representa o valor do saque e deve ser maior que zero e menor ou igual ao <see cref="Saldo"/>. </param>
        /// <returns> Retorna true se o saque for realizado ou false se não </returns>
        public bool Sacar(double valor)
        {
            if (_saldo > valor && valor > 0)
            {
                _saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(double valor, Conta contaDestino)
        {
            if (_saldo > valor && valor > 0)
            {
                _saldo -= valor;
                contaDestino.Saldo += valor;
                return true;
            }
            return false;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        protected bool Equals(Conta other)
        {
            return _numero_conta == other._numero_conta && _numero_agencia == other._numero_agencia;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Conta)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_numero_conta, _numero_agencia);
        }

        /*Comparer gerado com atalho ReSharper
        private sealed class SaldoRelationalComparer : IComparer<Conta>
        {
            public int Compare(Conta x, Conta y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (ReferenceEquals(null, y)) return 1;
                if (ReferenceEquals(null, x)) return -1;
                return x._saldo.CompareTo(y._saldo);
            }
        }
        public static IComparer<Conta> SaldoComparer { get; } = new SaldoRelationalComparer();
        */

        //CompareTo implementado
        public int CompareTo(object? obj)
        {
            // Retornar negativo quando a instância precede o obj
            // Retornar zero quando nossa instância e obj forem equivalentes;
            // Retornar positivo diferente de zero quando a precedência for de obj;

            var outraConta = obj as Conta;

            if (outraConta == null)
            {
                return 1;
            }
               
            if (Saldo > outraConta.Saldo)
            {
                return 1;
            }

            if (Saldo == outraConta.Saldo)
            {
                return 0;
            }

            return -1;
        }

    }
}