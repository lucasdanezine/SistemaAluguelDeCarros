﻿namespace SistemaAluguelDeCarros.Entities
{
    class Veiculo
    {
        public string Modelo { get; set; }

        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }
    }
}
