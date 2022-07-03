namespace UsesLibrary.Extensoess
{
    public static class ListExtensoes
    {
        //Metodo de extensão generico
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }
    }
}
