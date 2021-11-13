using System;

namespace SistemaAluguelDeCarros.Entities
{
    class AluguelDeCarros
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo Veiculo { get; set; }
        public Invoice Invoice { get; set; }

        public AluguelDeCarros(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;
            Invoice = null;
        }
    }
}
