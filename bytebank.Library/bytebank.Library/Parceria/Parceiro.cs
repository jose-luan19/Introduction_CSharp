using Bytebank.Modelos.SistemaInterno;

namespace Bytebank.Modelos.Parceria
{
    internal class Parceiro : IAutenticavel
    {

        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();

        public string Senha { get; set; }

        public bool Autenticar(string senha)
            => _autenticacaoHelper.CompararSenhas(Senha, senha);
    }
}
