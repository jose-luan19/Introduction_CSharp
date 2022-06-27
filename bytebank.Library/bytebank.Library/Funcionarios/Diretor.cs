namespace Bytebank.Modelos.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        internal protected override double GetBonificacao()
        {
            return (int)(Salario / 2);
        }

        public Diretor(double salario) : base(salario)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }


    }
}
