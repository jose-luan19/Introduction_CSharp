namespace bytebank.SistemaDependente
{
    public class ExtratorArgURL
    {
        private readonly string _argumentos;

        public string URL { get; }

        public ExtratorArgURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }

            _argumentos = url.Substring(url.IndexOf('?') + 1);

            URL = url;
        }

        public string GetValor(string nomeParametro)
        {
            string argumentosUpper = _argumentos.ToUpper();
            nomeParametro = nomeParametro.ToUpper();

            string termo = nomeParametro + "=";
            int indiceTermo = argumentosUpper.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);


            if (resultado.Contains('&'))
            {
                return resultado.Remove(resultado.IndexOf('&'));
            }
            return resultado;
        }
    }
}
