using System;
using System.Globalization;
using SistemaAluguelDeCarros.Entities;
using SistemaAluguelDeCarros.Services;
namespace SistemaAluguelDeCarros
{
    class Program
    {
        //Sistema para aplicar interface no .Net core C#.
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do Aluguel");
            Console.WriteLine("Modelo do carro");
            string modelo = Console.ReadLine();
            Console.WriteLine("Entre com a data e horário de entrada (dd/MM/yyyy hh:mm): ");
            DateTime dataSaida = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com a data e horário de devolução (dd/MM/yyyy hh:mm): ");
            DateTime dataEntrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Veiculo veiculo = new Veiculo(modelo);
            AluguelDeCarros carroAlugado = new AluguelDeCarros(dataSaida, dataEntrada,veiculo );

            Console.WriteLine("Digite o Preço por hora");
            double hora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o Preço por dia");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ServicoAluguel servicoAluguel = new ServicoAluguel(hora, dia, new ServicoImpostoBrasil());

            servicoAluguel.ProcessInvoice(carroAlugado);

            Console.WriteLine(carroAlugado.Invoice);

        }
    }
}
