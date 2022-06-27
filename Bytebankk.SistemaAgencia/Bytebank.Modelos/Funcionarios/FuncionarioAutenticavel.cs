using bytebank.Modelos.SistemaInterno;

namespace bytebank.Modelos.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {


        public string Senha { get; set; }

        public bool Autenticar(string senha)
            => Senha == senha;

        public FuncionarioAutenticavel(double salario) : base(salario)
        {
        }
    }
}
