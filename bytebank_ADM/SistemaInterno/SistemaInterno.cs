using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado != true)
            {
                Console.WriteLine("Senha Incorreta");
                return false;
            }

            Console.WriteLine("Bem vindo ao sistema");
            return true;
        }
    }
}
