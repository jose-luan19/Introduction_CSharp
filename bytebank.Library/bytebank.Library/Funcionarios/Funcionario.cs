namespace Bytebank.Modelos.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public double Salario { get; protected set; }

        public static int TotalFuncionarios { get; private set; }


        public override string ToString()
        {
            return $"Nome: {Nome}, " +
                   $"Cpf: {Cpf}, " +
                   $"Salario: {Salario}";
        }

        public Funcionario(double salario)
        {
            Salario = salario;
            Console.WriteLine("Criando Funcionario");
            TotalFuncionarios++;
        }

        /*public virtual double GetBonificacao() => Salario * 0.1; //arrow function*/
        internal protected abstract double GetBonificacao();

        /*public virtual void AumentarSalario()
        {
            Salario *= 1.2;
        }*/
        public abstract void AumentarSalario();
    }
}
