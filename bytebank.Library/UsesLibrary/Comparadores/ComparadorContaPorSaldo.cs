using Bytebank.Modelos;

namespace UsesLibrary.Comparadores
{
    internal class ComparadorContaPorSaldo : IComparer<Conta>
    {
        /// <summary>Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.</summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <returns>A signed integer that indicates the relative values of <paramref name="x" /> and <paramref name="y" />, as shown in the following table.
        /// <list type="table"><listheader><term> Value</term><description> Meaning</description></listheader><item><term> Less than zero</term><description><paramref name="x" /> is less than <paramref name="y" />.</description></item><item><term> Zero</term><description><paramref name="x" /> equals <paramref name="y" />.</description></item><item><term> Greater than zero</term><description><paramref name="x" /> is greater than <paramref name="y" />.</description></item></list></returns>
        public int Compare(Conta x, Conta y)
        {
            if (x == y)
            {
                return 0;
            }

            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }

            return x.Saldo.CompareTo(y.Saldo);

            /*

             if (x.Saldo < y.Saldo)
            {
                return -1; // x fica na frente de y
            }

            if (x.Saldo == y.Saldo)
            {
                return 0; // são equivalentes
            }

            return 1; // y fica na frente de x

            */
        }
    }
}
