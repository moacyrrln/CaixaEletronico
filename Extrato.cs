using System;
using System.Collections.Generic;


namespace GamaCaixaEletronico
{
    public class Extrato
    {
        public List<ListaDeSaque> _dadosdosaque;

        public Extrato(List<ListaDeSaque> dadosdosaque)
        {
            _dadosdosaque = dadosdosaque;
        }

        public void ImprimirNaTela()
        {
            Console.Clear();
            foreach (ListaDeSaque linha in _dadosdosaque)
            {
                Console.WriteLine($"Dados do saque: {linha._datahoradosaque} - R${linha._totalsacado},00");
            }
            Console.Write("\n\n");
        }
    }
}
