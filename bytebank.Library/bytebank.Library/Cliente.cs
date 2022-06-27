
namespace Bytebank.Modelos.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Profissao { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, CPF: {CPF}, Profissao: {Profissao}";
        }
    }
}
