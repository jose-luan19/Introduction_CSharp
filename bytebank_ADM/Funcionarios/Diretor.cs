using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public override double GetBonificacao()
        {
            return  (int) (Salario / 2);
        }

        public Diretor(double salario):base(salario)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }


    }
}
