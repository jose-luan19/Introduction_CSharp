namespace Bytebank.Modelos.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(double salario) : base(salario)
        {

        }

        internal protected override double GetBonificacao()
        {
            return (int)(Salario / 4);
        }

        public override void AumentarSalario()
        {
            Salario *= 1.2;
        }
    }
}
