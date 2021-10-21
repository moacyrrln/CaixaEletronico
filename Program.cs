using System;
using System.Collections.Generic;

/*
 * Exercício Caixa Eletrônico
Fazer um programa do tipo Console que simule saque de um caixa eletrônico e sempre retorne o menor numero de notas possível.
Especificações:
As notas válidas são pode ser 100, 50, 20, 10, 5
As notas são infinitas
Todos os saques devem ser guardados em uma lista de Saques
O Saque deve conter a data e hora de quando foi realizado e o valor
Caso o saque não seja possível não registrar e informar a mensagem: “valor inválido”
No programa principal deve ser possível sacar de qualquer caixa eletrônico
DEVE-SE aplicar todos os conceitos passados em aula.
Formas de entrega:
Enviar a URL do repositorio no Github no Slack
Se caso não funcionar enviar um .zip pelo chat com o nome respectivo: NomeDoAluno.zip
Ex: FilipeCecconDeAlencar.zip
*/

namespace GamaCaixaEletronico
{
    class Program
    {
        static void Main()
        {
            List<ListaDeSaque> ListaDeSaques = new();
            while (true)
            {
                Console.Write("Informe o valor a ser Sacado (digite F para finalizar, digite L para listar todos os saques): ");
                var ValorASerSacado = Console.ReadLine();
                bool isNumber = int.TryParse(ValorASerSacado, out _);
                if (isNumber)
                {
                    RetornoDoValorASerSacado(ListaDeSaques, ValorASerSacado);
                }
                else
                {
                    if (ValorASerSacado == "F" || ValorASerSacado == "f")
                    {
                        break;
                    }

                    if (ValorASerSacado == "L" || ValorASerSacado == "l")
                    {
                        var extrato = new Extrato(ListaDeSaques);
                        extrato.ImprimirNaTela();
                    }
                }

            }
        }

        private static void RetornoDoValorASerSacado(List<ListaDeSaque> ListaDeSaques, string ValorASerSacado)
        {
            var Saque = CaixaEletronico.Saque(Int32.Parse(ValorASerSacado));
            if (Saque.Total == 0)
            {
                Console.WriteLine("Valor Inválido");
            }
            else
            {
                Console.WriteLine($"100: {Saque.Cem}");
                Console.WriteLine($"050: {Saque.Cinquenta}");
                Console.WriteLine($"020: {Saque.Vinte}");
                Console.WriteLine($"010: {Saque.Dez}");
                Console.WriteLine($"005: {Saque.Cinco}");
                Console.WriteLine($"Data e Hora do Saque: {Saque.DataHoraDoSaque}\n\n");
                var DadosDoSaque = new ListaDeSaque(Saque.DataHoraDoSaque, Saque.Total);
                ListaDeSaques.Add(DadosDoSaque);
            }
        }
    }
}
