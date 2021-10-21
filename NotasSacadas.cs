using System;


namespace CaixaEletronico
{
    class NotasSacadas
    {
        public int Cem { get; set; }
        public int Cinquenta { get; set; }
        public int Vinte { get; set; }
        public int Dez { get; set; }
        public int Cinco { get; set; }
        public int Total { get; set; }

        public DateTime DataHoraDoSaque = DateTime.Now;
        
    }
}
