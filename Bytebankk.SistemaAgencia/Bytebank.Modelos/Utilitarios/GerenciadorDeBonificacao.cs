using bytebank.Modelos.Funcionarios;

namespace bytebank.Modelos.Utilitarios
{
    internal class GerenciadorDeBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double TotalBonificacao
        {
            get => _totalBonificacao;
        }
    }
}
