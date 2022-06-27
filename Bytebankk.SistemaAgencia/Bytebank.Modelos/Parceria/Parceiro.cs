using bytebank.Modelos.SistemaInterno;

namespace bytebank.Modelos.Parceria
{
    internal class Parceiro : IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
            => Senha == senha;
    }
}
