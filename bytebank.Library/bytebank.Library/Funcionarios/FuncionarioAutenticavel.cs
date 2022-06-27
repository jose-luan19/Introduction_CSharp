using Bytebank.Modelos.SistemaInterno;

namespace Bytebank.Modelos.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {


        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();

        public string Senha { get; set; }

        public bool Autenticar(string senha)
            => _autenticacaoHelper.CompararSenhas(Senha, senha);

        public FuncionarioAutenticavel(double salario) : base(salario)
        {
        }
    }
}
