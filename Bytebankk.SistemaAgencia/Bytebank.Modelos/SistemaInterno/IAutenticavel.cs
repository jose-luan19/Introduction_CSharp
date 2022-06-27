using bytebank.Modelos.Funcionarios;

namespace bytebank.Modelos.SistemaInterno
{
    public interface IAutenticavel
    {
        /*protected Autenticavel(double salario) : base(salario)
        {
        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
            => Senha == senha;*/

        public bool Autenticar(string senha);
    }
}
