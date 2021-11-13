using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAluguelDeCarros.Services
{
    class ServicoImpostoBrasil : IServicoImposto
    {
        public double Taxa(double montante)
        {
            if (montante <= 100.0)
            {
                return montante * 0.2;
            }
            else
            {
                return montante * 0.15;
            }
        }
    }
}
