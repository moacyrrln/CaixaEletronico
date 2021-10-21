using System;
using System.Collections.Generic;

namespace GamaCaixaEletronico
{
    public class DadosDoSaque
    {
        public DateTime _datahoradosaque;
        public int _totalsacado;

        public DadosDoSaque(DateTime datahoradosaque, int totalsacado)
        {
            _datahoradosaque = datahoradosaque;
            _totalsacado = totalsacado;
        }

        public static void ListarNaTela(List<DadosDoSaque> ListaDeSaques)
        {
            Console.Clear();
            foreach (DadosDoSaque linha in ListaDeSaques)
            {
                Console.WriteLine($"Dados do saque: {linha._datahoradosaque} - R${linha._totalsacado}");
            }
        }
    }
}