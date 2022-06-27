namespace bytebank.Modelos.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(double salario):base(salario)
        {

        }

        public override double GetBonificacao()
        {
            return (int)(Salario / 8);
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
