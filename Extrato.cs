using System;
using System.Collections.Generic;


namespace GamaCaixaEletronico
{
    public class Extrato
    {
        public List<DadosDoSaque> _dadosdosaque;

        public Extrato(List<DadosDoSaque> dadosdosaque)
        {
            _dadosdosaque = dadosdosaque;
        }

        public void ImprimirNaTela()
        {
            Console.Clear();
            foreach (DadosDoSaque linha in _dadosdosaque)
            {
                Console.WriteLine($"Dados do saque: {linha._datahoradosaque} - R${linha._totalsacado},00");
            }
            Console.Write("\n\n");
        }
    }
}
