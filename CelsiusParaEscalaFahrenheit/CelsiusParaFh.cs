using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusParaEscalaFahrenheit
{
    internal class CelsiusParaFh
    {

        public double TempF;
        public double CalcularTempC()
        { return (TempF * 1.8) - 32; }
    }
}
