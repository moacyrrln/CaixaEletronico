using System;
using System.Collections.Generic;

namespace GamaCaixaEletronico
{
    public class ListaDeSaque
    {
        public DateTime _datahoradosaque;
        public int _totalsacado;

        public ListaDeSaque(DateTime datahoradosaque, int totalsacado)
        {
            _datahoradosaque = datahoradosaque;
            _totalsacado = totalsacado;
        }

        public static void ListarNaTela(List<ListaDeSaque> ListaDeSaques)
        {
            Console.Clear();
            foreach (ListaDeSaque linha in ListaDeSaques)
            {
                Console.WriteLine($"Dados do saque: {linha._datahoradosaque} - R${linha._totalsacado}");
            }
        }
    }
}