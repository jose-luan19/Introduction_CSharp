/*using Newtonsoft.Json;*/
using bytebank.Modelos.Titular;

namespace bytebank.Modelos
{
    public class Conta
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
    }
}