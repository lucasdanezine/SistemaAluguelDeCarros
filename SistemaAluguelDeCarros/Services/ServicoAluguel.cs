using System;
using SistemaAluguelDeCarros.Entities;

namespace SistemaAluguelDeCarros.Services
{
    class ServicoAluguel
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private IServicoImposto _servicoImposto;

        public ServicoAluguel(double precoPorHora, double precoPorDia, IServicoImposto taxaServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _servicoImposto = taxaServico;
        }

        public void ProcessInvoice(AluguelDeCarros aluguelDeCarros)
        {
            TimeSpan duracao = aluguelDeCarros.Fim.Subtract(aluguelDeCarros.Inicio);

            double basicPayment = 0.0;

            if(duracao.TotalHours <= 12.0)
            {
                basicPayment = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                basicPayment = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _servicoImposto.Taxa(basicPayment);

            aluguelDeCarros.Invoice = new Invoice(basicPayment, taxa);
        }
    }
}
