using CaixaEletronico;

namespace GamaCaixaEletronico
{
    internal class CaixaEletronico
    {
        public static NotasSacadas Saque(int valor)
        {
            var Notas = new NotasSacadas
            {
                Cem = 0,
                Cinquenta = 0,
                Vinte = 0,
                Dez = 0,
                Cinco = 0,
                Total = 0
            };

            if (valor % 5 != 0) return Notas;

            Notas.Cem = valor / 100;
            Notas.Cinquenta = (valor - Notas.Cem * 100) / 50;
            Notas.Vinte = (valor - Notas.Cem * 100 - Notas.Cinquenta * 50) / 20;
            Notas.Dez = (valor - Notas.Cem * 100 - Notas.Cinquenta * 50 - Notas.Vinte * 20) / 10;
            Notas.Cinco = (valor - Notas.Cem * 100 - Notas.Cinquenta * 50 - Notas.Vinte * 20 - Notas.Dez * 10) / 5;
            Notas.Total = valor;

            return Notas;
        }
    }



}