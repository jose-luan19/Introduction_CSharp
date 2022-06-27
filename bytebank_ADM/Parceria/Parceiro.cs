using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Parceria
{
    internal class Parceiro : IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
            => Senha == senha;
    }
}
