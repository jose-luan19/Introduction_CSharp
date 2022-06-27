﻿namespace bytebank.Modelos.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(double salario) : base(salario)
        {

        }

        public override double GetBonificacao()
        {
            return (int)(Salario / 5);
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

    }
}
